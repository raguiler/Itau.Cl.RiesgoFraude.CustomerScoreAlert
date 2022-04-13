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
    public partial class HonoraryTicket : IEquatable<HonoraryTicket>
    {
        /// <summary>
        /// Gets or Sets MonthHonoraryTickets
        /// </summary>

        [DataMember(Name = "monthHonoraryTickets")]
        public string MonthHonoraryTickets { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>

        [DataMember(Name = "period")]
        public long? Period { get; set; }

        /// <summary>
        /// Gets or Sets GrossFee
        /// </summary>

        [DataMember(Name = "grossFee")]
        public long? GrossFee { get; set; }

        /// <summary>
        /// Gets or Sets WithholdingThird
        /// </summary>

        [DataMember(Name = "withholdingThird")]
        public long? WithholdingThird { get; set; }

        /// <summary>
        /// Gets or Sets Ppm
        /// </summary>

        [DataMember(Name = "ppm")]
        public long? Ppm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HonoraryTicket {\n");
            sb.Append("  MonthHonoraryTickets: ").Append(MonthHonoraryTickets).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  GrossFee: ").Append(GrossFee).Append("\n");
            sb.Append("  WithholdingThird: ").Append(WithholdingThird).Append("\n");
            sb.Append("  Ppm: ").Append(Ppm).Append("\n");
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
            return obj.GetType() == GetType() && Equals((HonoraryTicket)obj);
        }

        /// <summary>
        /// Returns true if HonoraryTicket instances are equal
        /// </summary>
        /// <param name="other">Instance of HonoraryTicket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HonoraryTicket other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    MonthHonoraryTickets == other.MonthHonoraryTickets ||
                    MonthHonoraryTickets != null &&
                    MonthHonoraryTickets.Equals(other.MonthHonoraryTickets)
                ) &&
                (
                    Period == other.Period ||
                    Period != null &&
                    Period.Equals(other.Period)
                ) &&
                (
                    GrossFee == other.GrossFee ||
                    GrossFee != null &&
                    GrossFee.Equals(other.GrossFee)
                ) &&
                (
                    WithholdingThird == other.WithholdingThird ||
                    WithholdingThird != null &&
                    WithholdingThird.Equals(other.WithholdingThird)
                ) &&
                (
                    Ppm == other.Ppm ||
                    Ppm != null &&
                    Ppm.Equals(other.Ppm)
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
                if (MonthHonoraryTickets != null)
                    hashCode = hashCode * 59 + MonthHonoraryTickets.GetHashCode();
                if (Period != null)
                    hashCode = hashCode * 59 + Period.GetHashCode();
                if (GrossFee != null)
                    hashCode = hashCode * 59 + GrossFee.GetHashCode();
                if (WithholdingThird != null)
                    hashCode = hashCode * 59 + WithholdingThird.GetHashCode();
                if (Ppm != null)
                    hashCode = hashCode * 59 + Ppm.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(HonoraryTicket left, HonoraryTicket right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HonoraryTicket left, HonoraryTicket right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}