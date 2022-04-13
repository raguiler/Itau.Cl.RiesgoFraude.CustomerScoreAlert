using Microsoft.Extensions.Logging;
using System.Collections;

namespace Itau.Cl.RF.CustomerRelationshipMgmnt.Bff.Infra
{
    public static class EnvironmentVariables
    {
        public static void Init(IDictionary envVariables, Action<ILoggingBuilder> _loggerBuilder)
        {
            using var loggerFactory = LoggerFactory.Create(_loggerBuilder);

            ILogger logger = loggerFactory.CreateLogger("EnvironmentVariables");

            try
            {
                COMPUTERNAME = envVariables[nameof(COMPUTERNAME)].ToString();
                logger.LogInformation($"Env > {nameof(COMPUTERNAME)}= {COMPUTERNAME.TakeLast(4)}");

                ClientIdApicGw = envVariables[nameof(ClientIdApicGw)].ToString();
                logger.LogInformation($"Env > {nameof(ClientIdApicGw)}= {ClientIdApicGw.TakeLast(4)}");

                ClientSecretApicGw = envVariables[nameof(ClientSecretApicGw)].ToString();
                logger.LogInformation($"Env > {nameof(ClientSecretApicGw)}= {ClientSecretApicGw.TakeLast(4)}");

                ApiKeyDatamart = envVariables[nameof(ApiKeyDatamart)].ToString();
                logger.LogInformation($"Env > {nameof(ApiKeyDatamart)}= {ApiKeyDatamart.TakeLast(4)}");

                ASPNETCORE_ENVIRONMENT = envVariables[nameof(ASPNETCORE_ENVIRONMENT)].ToString();
                logger.LogInformation($"Env > {nameof(ASPNETCORE_ENVIRONMENT)}= {ASPNETCORE_ENVIRONMENT.TakeLast(4)}");
            }
            catch (Exception ex)
            {
                logger.LogError($"Error al configurar las variables de entorno, uno de los valores es invalido o null. {ex.Message}");
            }
        }

        /// <summary>
        /// Client Id para consumo de API Connect Gateway
        /// </summary>        
        public static string ClientIdApicGw { get; set; }

        /// <summary>
        /// Client Secret para consumo de API Connect Gateway
        /// </summary>
        public static string ClientSecretApicGw { get; set; }


        /// <summary>
        /// API key (x-functions-key) para consumo de APIs de Datamart 
        /// </summary>
        public static string ApiKeyDatamart { get; set; }

        /// <summary>
        /// Environment variable
        /// </summary>
        public static string ASPNETCORE_ENVIRONMENT { get; set; }

        /// <summary>
        /// ComputerName
        /// </summary>
        public static string COMPUTERNAME { get; set; }
    }
}