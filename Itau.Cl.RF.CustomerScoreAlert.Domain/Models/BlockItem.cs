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
    public partial class BlockItem
    {
        /// <summary>
        /// Gets or Sets FaTypeId
        /// </summary>

        [JsonPropertyName("faTypeId")]
        public string FaTypeId { get; set; }

        /// <summary>
        /// Gets or Sets FaTypeDesc
        /// </summary>

        [JsonPropertyName("faTypeDesc")]
        public string FaTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets FaId
        /// </summary>

        [JsonPropertyName("faId")]
        public string FaId { get; set; }


        /// <summary>
        /// Gets or Sets BlockComment
        /// </summary>

        [JsonPropertyName("blockComment")]
        public string BlockComment { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets InternalCode
        /// </summary>

        [JsonPropertyName("UserIdDesc")]
        public string UserIdDesc { get; set; }


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
