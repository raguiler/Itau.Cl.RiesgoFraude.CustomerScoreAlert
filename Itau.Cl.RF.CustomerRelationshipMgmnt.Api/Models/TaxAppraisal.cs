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
    public partial class TaxAppraisal : IEquatable<TaxAppraisal>
    {
        /// <summary>
        /// Gets or Sets ValueTaxAppraisal
        /// </summary>

        [DataMember(Name = "valueTaxAppraisal")]
        public long? ValueTaxAppraisal { get; set; }

        /// <summary>
        /// Gets or Sets Semester
        /// </summary>

        [DataMember(Name = "semester")]
        public string Semester { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxAppraisal {\n");
            sb.Append("  ValueTaxAppraisal: ").Append(ValueTaxAppraisal).Append("\n");
            sb.Append("  Semester: ").Append(Semester).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TaxAppraisal)obj);
        }

        /// <summary>
        /// Returns true if TaxAppraisal instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxAppraisal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxAppraisal other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    ValueTaxAppraisal == other.ValueTaxAppraisal ||
                    ValueTaxAppraisal != null &&
                    ValueTaxAppraisal.Equals(other.ValueTaxAppraisal)
                ) &&
                (
                    Semester == other.Semester ||
                    Semester != null &&
                    Semester.Equals(other.Semester)
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
                if (ValueTaxAppraisal != null)
                    hashCode = hashCode * 59 + ValueTaxAppraisal.GetHashCode();
                if (Semester != null)
                    hashCode = hashCode * 59 + Semester.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(TaxAppraisal left, TaxAppraisal right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TaxAppraisal left, TaxAppraisal right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
