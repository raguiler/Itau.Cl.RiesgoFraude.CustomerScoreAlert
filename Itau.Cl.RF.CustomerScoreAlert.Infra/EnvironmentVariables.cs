using Microsoft.Extensions.Logging;
using System.Collections;

namespace Itau.Cl.RF.CustomerScoreAlert.Infra
{
    public static class EnvironmentVariables
    {
        public static void Init(IDictionary envVariables, Action<ILoggingBuilder> _loggerBuilder)
        {
            using var loggerFactory = LoggerFactory.Create(_loggerBuilder);

            ILogger logger = loggerFactory.CreateLogger("EnvironmentVariables");

            try
            {
                ClientIdBScore = envVariables[nameof(ClientIdBScore)].ToString();
                logger.LogInformation($"Env > {nameof(ClientIdBScore)}= {ClientIdBScore.TakeLast(4)}");

                ClientSecretBScore = envVariables[nameof(ClientSecretBScore)].ToString();
                logger.LogInformation($"Env > {nameof(ClientSecretBScore)}= {ClientSecretBScore.TakeLast(4)}");

                ASPNETCORE_ENVIRONMENT = envVariables[nameof(ASPNETCORE_ENVIRONMENT)].ToString();
                logger.LogInformation($"Env > {nameof(ASPNETCORE_ENVIRONMENT)}= {ASPNETCORE_ENVIRONMENT.TakeLast(4)}");

                ChannelIdBScore = envVariables[nameof(ChannelIdBScore)].ToString();
                logger.LogInformation($"Env > {nameof(ChannelIdBScore)}= {ChannelIdBScore.TakeLast(4)}");

                ChannelCodeAuthFactor = envVariables[nameof(ChannelCodeAuthFactor)].ToString();
                logger.LogInformation($"Env > {nameof(ChannelCodeAuthFactor)}= {ChannelCodeAuthFactor.TakeLast(4)}");

                ApplicationNameAuthFactor = envVariables[nameof(ApplicationNameAuthFactor)].ToString();
                logger.LogInformation($"Env > {nameof(ApplicationNameAuthFactor)}= {ApplicationNameAuthFactor.TakeLast(4)}");

                ApplicationCodeAuthFactor = envVariables[nameof(ApplicationCodeAuthFactor)].ToString();
                logger.LogInformation($"Env > {nameof(ApplicationCodeAuthFactor)}= {ApplicationCodeAuthFactor.TakeLast(4)}");

                ClientIdAuthFactor = envVariables[nameof(ClientIdAuthFactor)].ToString();
                logger.LogInformation($"Env > {nameof(ClientIdAuthFactor)}= {ClientIdAuthFactor.TakeLast(4)}");

                ClientSecretAuthFactor = envVariables[nameof(ClientSecretAuthFactor)].ToString();
                logger.LogInformation($"Env > {nameof(ClientSecretAuthFactor)}= {ClientSecretAuthFactor.TakeLast(4)}");

                ClientIdBlock = envVariables[nameof(ClientIdBlock)].ToString();
                logger.LogInformation($"Env > {nameof(ClientIdBlock)}= {ClientIdBlock.TakeLast(4)}");

                ClientSecretBlock = envVariables[nameof(ClientSecretBlock)].ToString();
                logger.LogInformation($"Env > {nameof(ClientSecretBlock)}= {ClientSecretBlock.TakeLast(4)}");

               //API Paths
                var basePathBiometricScore = envVariables[nameof(BasePathBiometricScore)].ToString();
                logger.LogInformation($"Env > {nameof(BasePathBiometricScore)} = {basePathBiometricScore}");
                BasePathBiometricScore = new Uri(basePathBiometricScore);

                var basePathAuthFactor = envVariables[nameof(BasePathAuthFactor)].ToString();
                logger.LogInformation($"Env > {nameof(BasePathAuthFactor)} = {basePathAuthFactor}");
                BasePathAuthFactor = new Uri(basePathAuthFactor);

                var basePathBlock = envVariables[nameof(BasePathBlock)].ToString();
                logger.LogInformation($"Env > {nameof(BasePathBlock)} = {basePathBlock}");
                BasePathBlock = new Uri(basePathBlock);
           }
            catch (Exception ex)
            {
                logger.LogError($"Error al configurar las variables de entorno, uno de los valores es invalido o null. {ex.Message}");
            }
        }

        /// <summary>
        /// Client Id para consumo de API Biometric Score
        /// </summary>        
        public static string ClientIdBScore { get; set; }

        /// <summary>
        /// Client Secret para consumo de API Biometric Score
        /// </summary>
        public static string ClientSecretBScore { get; set; }

        /// <summary>
        /// Environment variable
        /// </summary>
        public static string ASPNETCORE_ENVIRONMENT { get; set; }


        //-----Biometric Score
        public static Uri BasePathBiometricScore { get; set; }
        public static string ChannelIdBScore { get; set; }

        //-----Auth Factor
        public static Uri BasePathAuthFactor { get; set; }
        public static string ChannelCodeAuthFactor { get; set; }
        public static string ApplicationNameAuthFactor { get; set; }
        public static string ApplicationCodeAuthFactor { get; set; }
        public static string ClientIdAuthFactor { get; set; }
        public static string ClientSecretAuthFactor { get; set; }

        //-----Block
        public static Uri BasePathBlock { get; set; }
        public static string ClientIdBlock { get; set; }
        public static string ClientSecretBlock { get; set; }

        //-----Send Notification
        public static Uri BasePathSendNotification { get; set; }
        public static string ClientIdSendNotification { get; set; }
        public static string ClientSecretSendNotification { get; set; }
    }
}