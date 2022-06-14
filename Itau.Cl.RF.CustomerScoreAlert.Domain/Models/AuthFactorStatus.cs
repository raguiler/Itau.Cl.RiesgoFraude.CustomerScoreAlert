/*
 * Datamart Customer Relationship Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Itau.Cl.RF.CustomerScoreAlert.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class AuthFactorStatus
    {
        /// <summary>
        /// Gets or Sets AuthenticationFactor
        /// </summary>

        [JsonPropertyName("AuthenticationFactor")]
        public AuthFactorItem[] AuthenticationFactors { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets ReasonPhrase
        /// </summary>
        /// 
        [JsonPropertyName("reasonPhrase")]
        public string ReasonPhrase { get; set; }


        /// <summary>
        /// Gets or Sets IsSuccessStatusCode
        /// </summary>

        [JsonPropertyName("isSuccessStatusCode")]
        public bool IsSuccessStatusCode { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}