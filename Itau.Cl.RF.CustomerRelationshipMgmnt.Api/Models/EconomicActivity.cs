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
    public partial class EconomicActivity : IEquatable<EconomicActivity>
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>

        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets OldCode
        /// </summary>

        [DataMember(Name = "oldCode")]
        public string OldCode { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets SubEconomicSector
        /// </summary>

        [DataMember(Name = "subEconomicSector")]
        public SubEconomicSector SubEconomicSector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EconomicActivity {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  OldCode: ").Append(OldCode).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  SubEconomicSector: ").Append(SubEconomicSector).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EconomicActivity)obj);
        }

        /// <summary>
        /// Returns true if EconomicActivity instances are equal
        /// </summary>
        /// <param name="other">Instance of EconomicActivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EconomicActivity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) &&
                (
                    OldCode == other.OldCode ||
                    OldCode != null &&
                    OldCode.Equals(other.OldCode)
                ) &&
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) &&
                (
                    SubEconomicSector == other.SubEconomicSector ||
                    SubEconomicSector != null &&
                    SubEconomicSector.Equals(other.SubEconomicSector)
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
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                if (OldCode != null)
                    hashCode = hashCode * 59 + OldCode.GetHashCode();
                if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                if (SubEconomicSector != null)
                    hashCode = hashCode * 59 + SubEconomicSector.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(EconomicActivity left, EconomicActivity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EconomicActivity left, EconomicActivity right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}