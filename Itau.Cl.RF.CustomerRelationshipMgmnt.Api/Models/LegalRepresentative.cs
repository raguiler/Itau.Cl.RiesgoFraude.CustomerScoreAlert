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
    public partial class LegalRepresentative : IEquatable<LegalRepresentative>
    {
        /// <summary>
        /// Gets or Sets NameCorporateLegalRepresentatives
        /// </summary>

        [DataMember(Name = "nameCorporateLegalRepresentatives")]
        public string NameCorporateLegalRepresentatives { get; set; }

        /// <summary>
        /// Gets or Sets ClientIdLegalRepresentatives
        /// </summary>

        [DataMember(Name = "clientIdLegalRepresentatives")]
        public long? ClientIdLegalRepresentatives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegalRepresentative {\n");
            sb.Append("  NameCorporateLegalRepresentatives: ").Append(NameCorporateLegalRepresentatives).Append("\n");
            sb.Append("  ClientIdLegalRepresentatives: ").Append(ClientIdLegalRepresentatives).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LegalRepresentative)obj);
        }

        /// <summary>
        /// Returns true if LegalRepresentative instances are equal
        /// </summary>
        /// <param name="other">Instance of LegalRepresentative to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegalRepresentative other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    NameCorporateLegalRepresentatives == other.NameCorporateLegalRepresentatives ||
                    NameCorporateLegalRepresentatives != null &&
                    NameCorporateLegalRepresentatives.Equals(other.NameCorporateLegalRepresentatives)
                ) &&
                (
                    ClientIdLegalRepresentatives == other.ClientIdLegalRepresentatives ||
                    ClientIdLegalRepresentatives != null &&
                    ClientIdLegalRepresentatives.Equals(other.ClientIdLegalRepresentatives)
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
                if (NameCorporateLegalRepresentatives != null)
                    hashCode = hashCode * 59 + NameCorporateLegalRepresentatives.GetHashCode();
                if (ClientIdLegalRepresentatives != null)
                    hashCode = hashCode * 59 + ClientIdLegalRepresentatives.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(LegalRepresentative left, LegalRepresentative right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LegalRepresentative left, LegalRepresentative right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
