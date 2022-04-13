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
    public partial class Administration : IEquatable<Administration>
    {
        /// <summary>
        /// Gets or Sets People
        /// </summary>

        [DataMember(Name = "people")]
        public List<string> People { get; set; }

        /// <summary>
        /// Gets or Sets TypePerformances
        /// </summary>

        [DataMember(Name = "typePerformances")]
        public string TypePerformances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Administration {\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  TypePerformances: ").Append(TypePerformances).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Administration)obj);
        }

        /// <summary>
        /// Returns true if Administration instances are equal
        /// </summary>
        /// <param name="other">Instance of Administration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Administration other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    People == other.People ||
                    People != null &&
                    People.SequenceEqual(other.People)
                ) &&
                (
                    TypePerformances == other.TypePerformances ||
                    TypePerformances != null &&
                    TypePerformances.Equals(other.TypePerformances)
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
                if (People != null)
                    hashCode = hashCode * 59 + People.GetHashCode();
                if (TypePerformances != null)
                    hashCode = hashCode * 59 + TypePerformances.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Administration left, Administration right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Administration left, Administration right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}