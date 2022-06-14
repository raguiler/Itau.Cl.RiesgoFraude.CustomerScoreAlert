using Microsoft.Extensions.Logging;
using System.Text.Json.Serialization;

namespace Itau.Cl.RF.CustomerScoreAlert.Infra.Exceptions
{
    /// <summary>
    /// Error generico que contiene e identifica errores manejados a nivel de aplicación
    /// </summary>
    [Serializable]
    public class GenericError : Exception
    {
        /// <summary>
        /// Codigo de error, usado para interpretaciones de aplicación
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Identifica el problema con un mensaje. String para debug, trazabilidad, y logs. NO COMPARAR en APPs con Mensajes.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Constructor Vacio
        /// </summary>  
        public GenericError()
        { }

        /// <summary>
        /// Constructor que inicializa con parametros de error
        /// </summary>
        public GenericError(string code, string message)
        {
            Code = code;
            Message = message;
        }
        public GenericError(EventId code, string message)
        {
            Code = code.ToString();
            Message = message;
        }


    }
}