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
    public partial class FineNotPay : IEquatable<FineNotPay>
    {
        /// <summary>
        /// Gets or Sets LocalPoliceJudge
        /// </summary>

        [DataMember(Name = "localPoliceJudge")]
        public string LocalPoliceJudge { get; set; }

        /// <summary>
        /// Gets or Sets RoleCause
        /// </summary>

        [DataMember(Name = "roleCause")]
        public string RoleCause { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FineNotPay {\n");
            sb.Append("  LocalPoliceJudge: ").Append(LocalPoliceJudge).Append("\n");
            sb.Append("  RoleCause: ").Append(RoleCause).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FineNotPay)obj);
        }

        /// <summary>
        /// Returns true if FineNotPay instances are equal
        /// </summary>
        /// <param name="other">Instance of FineNotPay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FineNotPay other)
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
                    RoleCause == other.RoleCause ||
                    RoleCause != null &&
                    RoleCause.Equals(other.RoleCause)
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
                if (RoleCause != null)
                    hashCode = hashCode * 59 + RoleCause.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(FineNotPay left, FineNotPay right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FineNotPay left, FineNotPay right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
