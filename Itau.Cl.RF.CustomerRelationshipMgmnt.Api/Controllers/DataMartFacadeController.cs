using Itau.Cl.RF.CustomerRelationshipMgmnt.Bff.API.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Itau.Cl.RF.CustomerRelationshipMgmnt.Bff.API.Controllers
{
    [Route("api/datamart/customer-relationship-management")]
    [ApiController]
    public class DataMartFacadeController : ControllerBase
    {
        private ILogger<DataMartFacadeController> _logger;
        private IHttpClientFactory _clientFactory;

        public DataMartFacadeController(ILogger<DataMartFacadeController> logger, IConfiguration configuration, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <response code="200">Detalle del registro de Empresa en un día de un sujeto de crédito.</response>
        [HttpGet]
        [Route("/api/company-in-one-day/{clientId}")]
        [SwaggerOperation("CompanyInOneDay")]
        [SwaggerResponse(statusCode: 200, type: typeof(CompanyInOneDay), description: "Detalle del registro de Empresa en un día de un sujeto de crédito.")]
        public virtual IActionResult CompanyInOneDay([FromRoute][Required] int? clientId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CompanyInOneDay));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<CompanyInOneDay>(exampleJson)
            //: default(CompanyInOneDay);
            ////TODO: Change the data returned
            //return new ObjectResult(example);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <response code="200">Detalle de la malla societaria del Sujeto de Crédito del rut indicado.</response>
        [HttpGet]
        [Route("/api/corporate-red/{clientId}")]
        [SwaggerOperation("CorporateRed")]
        [SwaggerResponse(statusCode: 200, type: typeof(Dictionary<string, CorporateRed>), description: "Detalle de la malla societaria del Sujeto de Crédito del rut indicado.")]
        public virtual IActionResult CorporateRed([FromRoute][Required] int? clientId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Dictionary<string, CorporateRed>));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<Dictionary<string, CorporateRed>>(exampleJson)
            //: default(Dictionary<string, CorporateRed>);
            ////TODO: Change the data returned
            //return new ObjectResult(example);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <response code="200">Información del Sujeto de Crédito del rut indicado.</response>
        [HttpGet]
        [Route("/api/credit-subject/{clientId}")]
        [SwaggerOperation("CreditSubject")]
        [SwaggerResponse(statusCode: 200, type: typeof(CreditSubject), description: "Información del Sujeto de Crédito del rut indicado.")]
        public virtual IActionResult CreditSubject([FromRoute][Required] int? clientId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CreditSubject));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<CreditSubject>(exampleJson)
            //: default(CreditSubject);
            ////TODO: Change the data returned
            //return new ObjectResult(example);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <response code="200">Detalle del último período de Balance del Sujeto de Crédito del rut indicado.</response>
        [HttpGet]
        [Route("/api/last-balance/{clientId}")]
        [SwaggerOperation("LastBalance")]
        [SwaggerResponse(statusCode: 200, type: typeof(LastBalance), description: "Detalle del último período de Balance del Sujeto de Crédito del rut indicado.")]
        public virtual IActionResult LastBalance([FromRoute][Required] int? clientId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(LastBalance));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<LastBalance>(exampleJson)
            //: default(LastBalance);
            ////TODO: Change the data returned
            //return new ObjectResult(example);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <param name="period">Periodo de consulta de la Información Comercial del Cliente</param>
        /// <response code="200">Periodos del Balance del Sujeto de Crédito para el rut indicado</response>
        [HttpGet]
        [Route("/api/period-balance/{clientId}/{period}")]
        [SwaggerOperation("PeriodBalance")]
        [SwaggerResponse(statusCode: 200, type: typeof(PeriodBalance), description: "Periodos del Balance del Sujeto de Crédito para el rut indicado")]
        public virtual IActionResult PeriodBalance([FromRoute][Required] int? clientId, [FromRoute][Required] int? period)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(PeriodBalance));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<PeriodBalance>(exampleJson)
            //: default(PeriodBalance);
            ////TODO: Change the data returned
            //return new ObjectResult(example);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <param name="quantity">Cantidad de meses a consultar</param>
        /// <response code="200">Períodos de Ventas del Sujeto de Crédito del rut indicado.</response>
        [HttpGet]
        [Route("/api/sale-periods/{clientId}/{quantity}")]
        [SwaggerOperation("SalePeriods")]
        [SwaggerResponse(statusCode: 200, type: typeof(SalePeriods), description: "Períodos de Ventas del Sujeto de Crédito del rut indicado.")]
        public virtual IActionResult SalePeriods([FromRoute][Required] int? clientId, [FromRoute][Required] string quantity)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SalePeriods));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<SalePeriods>(exampleJson)
            //: default(SalePeriods);
            ////TODO: Change the data returned
            //return new ObjectResult(example);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <response code="200">Detalle del Estado de Situación del Sujeto de Crédito del rut indicado.</response>
        [HttpGet]
        [Route("/api/status-situation/{clientId}")]
        [SwaggerOperation("StatusSituation")]
        [SwaggerResponse(statusCode: 200, type: typeof(StatusSituation), description: "Detalle del Estado de Situación del Sujeto de Crédito del rut indicado.")]
        public virtual IActionResult StatusSituation([FromRoute][Required] int? clientId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(StatusSituation));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<StatusSituation>(exampleJson)
            //: default(StatusSituation);
            ////TODO: Change the data returned
            //return new ObjectResult(example);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>

        /// <param name="clientId">RUT a consultar (sin dígito verificador)</param>
        /// <response code="200">Detalle del Registro de Vehículos del Sujeto de Crédito del rut indicado.</response>
        [HttpGet]
        [Route("/api/vehicle-registration/{clientId}")]
        [SwaggerOperation("VehicleRegistration")]
        [SwaggerResponse(statusCode: 200, type: typeof(VehicleRegistration), description: "Detalle del Registro de Vehículos del Sujeto de Crédito del rut indicado.")]
        public virtual IActionResult VehicleRegistration([FromRoute][Required] int? clientId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(VehicleRegistration));

            //string exampleJson = null;
            //exampleJson = "{\"empty\": false}";

            //var example = exampleJson != null
            //? JsonConvert.DeserializeObject<VehicleRegistration>(exampleJson)
            //: default(VehicleRegistration);
            ////TODO: Change the data returned
            //return new ObjectResult(example);

            throw new NotImplementedException();
        }
    }
}
