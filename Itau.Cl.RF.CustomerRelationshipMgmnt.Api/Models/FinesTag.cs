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
    public partial class FinesTag : IEquatable<FinesTag>
    {
        /// <summary>
        /// Gets or Sets DateFinesTag
        /// </summary>

        [DataMember(Name = "dateFinesTag")]
        public long? DateFinesTag { get; set; }

        /// <summary>
        /// Gets or Sets Fines
        /// </summary>

        [DataMember(Name = "fines")]
        public List<FineTag> Fines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinesTag {\n");
            sb.Append("  DateFinesTag: ").Append(DateFinesTag).Append("\n");
            sb.Append("  Fines: ").Append(Fines).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FinesTag)obj);
        }

        /// <summary>
        /// Returns true if FinesTag instances are equal
        /// </summary>
        /// <param name="other">Instance of FinesTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinesTag other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    DateFinesTag == other.DateFinesTag ||
                    DateFinesTag != null &&
                    DateFinesTag.Equals(other.DateFinesTag)
                ) &&
                (
                    Fines == other.Fines ||
                    Fines != null &&
                    Fines.SequenceEqual(other.Fines)
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
                if (DateFinesTag != null)
                    hashCode = hashCode * 59 + DateFinesTag.GetHashCode();
                if (Fines != null)
                    hashCode = hashCode * 59 + Fines.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(FinesTag left, FinesTag right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FinesTag left, FinesTag right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
