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


namespace Itau.Cl.RF.CustomerRelationshipMgmnt.Bff.API.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FineTag : IEquatable<FineTag>
    {
        /// <summary>
        /// Gets or Sets LocalPoliceJudge
        /// </summary>

        [DataMember(Name = "localPoliceJudge")]
        public string LocalPoliceJudge { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>

        [DataMember(Name = "quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FineTag {\n");
            sb.Append("  LocalPoliceJudge: ").Append(LocalPoliceJudge).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((FineTag)obj);
        }

        /// <summary>
        /// Returns true if FineTag instances are equal
        /// </summary>
        /// <param name="other">Instance of FineTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FineTag other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    LocalPoliceJudge == other.LocalPoliceJudge ||
                    LocalPoliceJudge != null &&
                    LocalPoliceJudge.Equals(other.LocalPoliceJudge)
                ) &&
                (
                    Quantity == other.Quantity ||
                    Quantity != null &&
                    Quantity.Equals(other.Quantity)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (LocalPoliceJudge != null)
                    hashCode = hashCode * 59 + LocalPoliceJudge.GetHashCode();
                if (Quantity != null)
                    hashCode = hashCode * 59 + Quantity.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(FineTag left, FineTag right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FineTag left, FineTag right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
