using Itau.Cl.Rf.CustomerScoreAlert.Bll.Implementation;
using Itau.Cl.RF.CustomerScoreAlert.Domain.Models;
using Itau.Cl.RF.CustomerScoreAlert.API.Dto;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Itau.Cl.Rf.CustomerScoreAlert.Infra.Exceptions;
using Newtonsoft.Json;

namespace Itau.Cl.RF.CustomerScoreAlert.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerScoreAlert : ControllerBase
    {
        private ILogger<CustomerScoreAlert> _logger;
        private IHttpClientFactory _clientFactory;
        private AlertImpl _alertImpl;
        private BiometricScore _biometricScore;
        private AuthFactor _authFactor;
        private Block _block;
        private SendNotification _sendNotification;
        private string authFactor;

        public CustomerScoreAlert(ILoggerFactory logger, IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            _logger = logger.CreateLogger<CustomerScoreAlert>();
            _clientFactory = clientFactory;
            _alertImpl = new AlertImpl(logger, clientFactory);
        }

        /// <summary>
        /// 
        /// </summary>

        [HttpPost]
        [Route("/inner/bcl/fraud-evaluation/v1.0/alerta")]
        [SwaggerOperation("CustomerScoreAlert")]
        //[SwaggerResponse(statusCode: 200, type: typeof(StatusSituation), description: "Alerta según Score obtenido para un cliente.")]
        public virtual IActionResult AlertSituation([Required] AlertRq alertrq)
        {
            _logger.LogTrace("Alert microservice begin", null);
            _logger.LogInformation("Alert Request values");

            if (_alertImpl.CustomerIdValidation(alertrq.Uuid))
            {
                _logger.LogInformation("Creating Request BiometricScore");

                _biometricScore = new BiometricScore() 
                {
                CustomerSessionId = alertrq.CustomerSessionId,
                Uuid = alertrq.Uuid,
                ActivityType = alertrq.ActivityType,
                Brand = alertrq.Brand,
                Ip = alertrq.Ip,
                Solution = alertrq.Solution,
                PlatformType = alertrq.PlatformType,
                UserAgent = alertrq.UserAgent,
                AuthMethodUsed = alertrq.AuthMethodUsed,
                BiometricLogin = true,
                NumOfFailedAuth = alertrq.NumOfFailedAuth,
                YearOfBirth = alertrq.YearOfBirth,
                AccountBalance = alertrq.AccountBalance,
                AccountOpendate = alertrq.AccountOpendate,
                PasswordChangeDate = alertrq.PasswordChangeDate,
                ThirdPartyFlow = alertrq.ThirdPartyFlow
                };

                _logger.LogInformation("BiometricScore Request values");

                _logger.LogInformation("BiometricScore API execute");

                var scoreStatus = _alertImpl.BiometricScoreStatus(_biometricScore);

                _logger.LogInformation("BiometricScore Response values");

                var alertResponse = new AlertResp()
                {
                    Bcstatus = scoreStatus.Result.Bcstatus,
                    Uuid = scoreStatus.Result.Uuid,
                    CustomerSessionId = scoreStatus.Result.CustomerSessionId,
                    Score = scoreStatus.Result.Score,
                    Bcscore = scoreStatus.Result.BcScore,
                    PolicyAction = scoreStatus.Result.PolicyAction,
                    PolicyId = scoreStatus.Result.PolicyId,
                    PolicyName = scoreStatus.Result.PolicyName,
                    AuthFactor = authFactor
                };

                //---------------sacar
                //scoreStatus.Result.IsSuccessStatusCode = true;
                //scoreStatus.Result.PolicyAction = "Decline";
                //---------------sacar

                if (scoreStatus.Result == null | scoreStatus.Result.IsSuccessStatusCode==false)
                {
                    //return new ObjectResult("Bad Response on BiometricScore") { StatusCode = 20}; //Ok();
                    //return Ok(alertResponse);
                    _logger.LogInformation("Bad Response on BiometricScore " + alertResponse.ToJson().ToString());
                    return StatusCode(204);
                }

                _logger.LogInformation("PolicyAction field evaluation " + alertResponse.ToJson().ToString());

                alertResponse.AuthFactor = "n/a";

                if (scoreStatus.Result.PolicyAction=="Allow")
                {
                    //return new ObjectResult("Allow Response on BiometricScore") { StatusCode = 200 };
                    _logger.LogInformation("Allow Response on BiometricScore " + alertResponse.ToJson().ToString());
                    return StatusCode(200, alertResponse);
                }

                if (scoreStatus.Result.PolicyAction == "Challenge")
                {
                    //return new ObjectResult("Challenge Response on BiometricScore") { StatusCode = 403 };
                    _logger.LogInformation("Challenge Response on BiometricScore " + alertResponse.ToJson().ToString());
                    return StatusCode(403, alertResponse);

                }

                if (scoreStatus.Result.PolicyAction == "Decline")
                {
                    _logger.LogInformation("PolicyAction is Decline. Begin");

                    //call AuthFactor API

                    _logger.LogInformation("AuthFactor API execute");
                    _authFactor = new AuthFactor()
                    {
                        UserRut = alertrq.UserRut,
                        UserTypeID = "", //Debe ir vacío
                        UserGroup = "personas", //Fijo
                        FATypeID = "1" //Fijo 1: Softtoken
                    };
                    _logger.LogInformation("AuthFactor Request values");
                    var authFactorStatus = _alertImpl.AuthenticationFactorStatus(_authFactor);

                    _logger.LogInformation("AuthFactor Response values");

                    if (authFactorStatus.Result == null | authFactorStatus.Result.IsSuccessStatusCode == false)
                    {
                        //return new ObjectResult("Bad Response on AuthFactor") { StatusCode = 200 };
                        _logger.LogInformation("Bad Response on AuthFactor " + alertResponse.ToJson().ToString());
                        return StatusCode(204);
                    }
                    else
                    {
                        if (authFactorStatus.Result.AuthenticationFactors != null)
                        {
                            if (authFactorStatus.Result.AuthenticationFactors.Length <= 0)
                            {
                                _logger.LogInformation("Bad Response on AuthFactor " + alertResponse.ToJson().ToString());
                                return StatusCode(204);
                            }
                        }
                    }

                    alertResponse.AuthFactor = authFactorStatus.Result.AuthenticationFactors[0].FAID;

                    //call Block API
                    _logger.LogInformation("Block API execute");
                    _block = new Block();
                    _block.Fa = new BlockItem[1];
                    _block.Fa[0] = new BlockItem()
                    {
                        FaTypeId = "1",
                        FaTypeDesc = authFactorStatus.Result.AuthenticationFactors[0].FATypeDesc,
                        FaId = authFactorStatus.Result.AuthenticationFactors[0].FAID,
                        BlockComment = "Bloqueo por evento Biocatch",
                        UserId = "personas",
                        UserIdDesc = "personas"
                    };
                    _logger.LogInformation("Block Request values");
                    var blockStatus = _alertImpl.BlockStatus(_block);

                    if (blockStatus.Result == null | blockStatus.Result.IsSuccessStatusCode == false)
                    {
                        //return new ObjectResult("Bad Response on Block") { StatusCode = 200 };
                        _logger.LogInformation("Bad Response on Block " + alertResponse.ToJson().ToString()); ;
                        return StatusCode(204);
                    }
                    else
                    {
                        if (blockStatus.Result.BlockFa != null)
                        {
                            if (blockStatus.Result.BlockFa.Length <= 0)
                            {
                                _logger.LogInformation("Bad Response on Block " + alertResponse.ToJson().ToString());
                                return StatusCode(204);
                            }
                        }
                    }

                    //return new ObjectResult("Decline Response on BiometricScore") { StatusCode = 403 };
                    _logger.LogInformation("PolicyAction is Decline. End " + alertResponse.ToJson().ToString());
                    return StatusCode(403, alertResponse);
                }

                _logger.LogInformation("Unknown alert flow " + alertResponse.ToJson().ToString());
                return StatusCode(204);
            }

            _logger.LogInformation("Uuid validation is false");
            return StatusCode(204);
        }
    }
}
