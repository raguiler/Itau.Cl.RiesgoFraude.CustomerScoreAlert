using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using Itau.Cl.RF.CustomerScoreAlert.Infra;
using Itau.Cl.RF.CustomerScoreAlert.Domain.Models;
using System.Net.Http.Json;
using Itau.Cl.Rf.CustomerScoreAlert.Infra.Exceptions;
//using Newtonsoft.Json;

namespace Itau.Cl.Rf.CustomerScoreAlert.Bll.Implementation
{
    public class AlertImpl
    {
        private readonly ILogger _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        //private readonly HttpClient _httpClient;

        public AlertImpl(ILoggerFactory logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger.CreateLogger<AlertImpl>();
            _httpClientFactory = httpClientFactory;
        }

        public bool CustomerIdValidation(string uuid_p)
        {
            if (uuid_p.Trim() == "no-uuid" | uuid_p.Trim() == "")
            {
                return false;
            }

            return true;
        }


        public async Task<ScoreStatus> BiometricScoreStatus(BiometricScore biometricScore_p)
        {
            try
            {
                _logger.LogInformation("BiometricScore method. Begin");
                HttpClient _httpClient;
                _httpClient = _httpClientFactory.CreateClient();
                _httpClient.DefaultRequestHeaders.Add("channel-id", EnvironmentVariables.ChannelIdBScore);
                _httpClient.DefaultRequestHeaders.Add("itau-client-id", EnvironmentVariables.ClientIdBScore);
                _httpClient.DefaultRequestHeaders.Add("itau-client-secret", EnvironmentVariables.ClientSecretBScore);

                var url = EnvironmentVariables.BasePathBiometricScore + "biometric/score";

                _logger.LogInformation("Post on Biometric/Score");
                var response = await _httpClient.PostAsJsonAsync(url, biometricScore_p);

                //if (response.IsSuccessStatusCode)
                //{
                var data = response.Content.ReadFromJsonAsync<ScoreStatus>();
                data.Result.StatusCode = (int)response.StatusCode;
                data.Result.ReasonPhrase = response.ReasonPhrase;
                data.Result.IsSuccessStatusCode = response.IsSuccessStatusCode;
                _logger.LogInformation("BiometricScore method. End");

                return data.Result;
                //}

                //throw new Exception($"ClientHttp Error: {response.StatusCode}");
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Exception on Biometric Score: {200}");
            }
        }

        public async Task<AuthFactorStatus> AuthenticationFactorStatus(AuthFactor authFactor_p)
        {
            try
            { 
                HttpClient _httpClient;
                _httpClient = _httpClientFactory.CreateClient();
                _httpClient.DefaultRequestHeaders.Add("channelCode", EnvironmentVariables.ChannelCodeAuthFactor);
                _httpClient.DefaultRequestHeaders.Add("aplicationName", EnvironmentVariables.ApplicationNameAuthFactor);
                _httpClient.DefaultRequestHeaders.Add("aplicationCode", EnvironmentVariables.ApplicationCodeAuthFactor);
                _httpClient.DefaultRequestHeaders.Add("X-IBM-Client-Id", EnvironmentVariables.ClientIdAuthFactor);
                _httpClient.DefaultRequestHeaders.Add("X-IBM-Client-Secret", EnvironmentVariables.ClientSecretAuthFactor);
                //itau-client-id
                //itau-client-secret

                var url = EnvironmentVariables.BasePathAuthFactor + "auth-factor";

                var response = await _httpClient.PostAsJsonAsync(url, authFactor_p);

                var data = response.Content.ReadFromJsonAsync<AuthFactorStatus>();
                data.Result.StatusCode = (int)response.StatusCode;
                data.Result.ReasonPhrase = response.ReasonPhrase;
                data.Result.IsSuccessStatusCode = response.IsSuccessStatusCode;
                return data.Result;

            }
            catch (Exception ex)
            {
                //throw new Exception(message: $"Exception on AuthFactor: {200}");
                throw new HttpResponseException("Internal Error", 400);
            }
        }

        public async Task<BlockStatus> BlockStatus(Block block_p)
        {
            try
            {
                HttpClient _httpClient;
                _httpClient = _httpClientFactory.CreateClient();
                _httpClient.DefaultRequestHeaders.Add("itau-client-id", EnvironmentVariables.ClientIdBlock);
                _httpClient.DefaultRequestHeaders.Add("itau-client-secret", EnvironmentVariables.ClientSecretBlock);

                var url = EnvironmentVariables.BasePathBlock + "block";

                var response = await _httpClient.PostAsJsonAsync(url, block_p);

                var data = response.Content.ReadFromJsonAsync<BlockStatus>();
                data.Result.StatusCode = (int)response.StatusCode;
                data.Result.ReasonPhrase = response.ReasonPhrase;
                data.Result.IsSuccessStatusCode = response.IsSuccessStatusCode;
                return data.Result;
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Exception on Block: {200}");
            }
        }

        public async Task<SendNotificationStatus> SendNotificationStatus(SendNotification sendnotification_p)
        {
            try
            {
                HttpClient _httpClient;
                _httpClient = _httpClientFactory.CreateClient();
                _httpClient.DefaultRequestHeaders.Add("channel-id", "11");
                _httpClient.DefaultRequestHeaders.Add("X-IBM-Client-Id", EnvironmentVariables.ClientIdSendNotification);
                _httpClient.DefaultRequestHeaders.Add("X-IBM-Client-Secret", EnvironmentVariables.ClientSecretSendNotification);

                var url = EnvironmentVariables.BasePathSendNotification + "send-notification";

                var response = await _httpClient.PostAsJsonAsync(url, sendnotification_p);

                var data = response.Content.ReadFromJsonAsync<SendNotificationStatus>();
                return data.Result;
            }
            catch (Exception ex)
            {
                throw new Exception(message: $"Exception on SendNotification: {200}");
            }
        }

    }


}
