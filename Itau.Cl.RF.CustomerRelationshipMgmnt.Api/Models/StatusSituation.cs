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
    public partial class StatusSituation : IEquatable<StatusSituation>
    {
        /// <summary>
        /// Gets or Sets ExecutiveIdCommercialInfo
        /// </summary>

        [DataMember(Name = "executiveIdCommercialInfo")]
        public string ExecutiveIdCommercialInfo { get; set; }

        /// <summary>
        /// Gets or Sets DateCommercial
        /// </summary>

        [DataMember(Name = "dateCommercial")]
        public long? DateCommercial { get; set; }

        /// <summary>
        /// Gets or Sets LegalRepresentatives
        /// </summary>

        [DataMember(Name = "legalRepresentatives")]
        public List<LegalRepresentative> LegalRepresentatives { get; set; }

        /// <summary>
        /// Gets or Sets Partners
        /// </summary>

        [DataMember(Name = "partners")]
        public List<StatusSituationPartner> Partners { get; set; }

        /// <summary>
        /// Gets or Sets Participations
        /// </summary>

        [DataMember(Name = "participations")]
        public List<Participation> Participations { get; set; }

        /// <summary>
        /// Gets or Sets RealEstate
        /// </summary>

        [DataMember(Name = "realEstate")]
        public List<RealState> RealEstate { get; set; }

        /// <summary>
        /// Gets or Sets TotalTaxAppraisal
        /// </summary>

        [DataMember(Name = "totalTaxAppraisal")]
        public int? TotalTaxAppraisal { get; set; }

        /// <summary>
        /// Gets or Sets HonoraryTickets
        /// </summary>

        [DataMember(Name = "honoraryTickets")]
        public List<HonoraryTicket> HonoraryTickets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusSituation {\n");
            sb.Append("  ExecutiveIdCommercialInfo: ").Append(ExecutiveIdCommercialInfo).Append("\n");
            sb.Append("  DateCommercial: ").Append(DateCommercial).Append("\n");
            sb.Append("  LegalRepresentatives: ").Append(LegalRepresentatives).Append("\n");
            sb.Append("  Partners: ").Append(Partners).Append("\n");
            sb.Append("  Participations: ").Append(Participations).Append("\n");
            sb.Append("  RealEstate: ").Append(RealEstate).Append("\n");
            sb.Append("  TotalTaxAppraisal: ").Append(TotalTaxAppraisal).Append("\n");
            sb.Append("  HonoraryTickets: ").Append(HonoraryTickets).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StatusSituation)obj);
        }

        /// <summary>
        /// Returns true if StatusSituation instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusSituation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusSituation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    ExecutiveIdCommercialInfo == other.ExecutiveIdCommercialInfo ||
                    ExecutiveIdCommercialInfo != null &&
                    ExecutiveIdCommercialInfo.Equals(other.ExecutiveIdCommercialInfo)
                ) &&
                (
                    DateCommercial == other.DateCommercial ||
                    DateCommercial != null &&
                    DateCommercial.Equals(other.DateCommercial)
                ) &&
                (
                    LegalRepresentatives == other.LegalRepresentatives ||
                    LegalRepresentatives != null &&
                    LegalRepresentatives.SequenceEqual(other.LegalRepresentatives)
                ) &&
                (
                    Partners == other.Partners ||
                    Partners != null &&
                    Partners.SequenceEqual(other.Partners)
                ) &&
                (
                    Participations == other.Participations ||
                    Participations != null &&
                    Participations.SequenceEqual(other.Participations)
                ) &&
                (
                    RealEstate == other.RealEstate ||
                    RealEstate != null &&
                    RealEstate.SequenceEqual(other.RealEstate)
                ) &&
                (
                    TotalTaxAppraisal == other.TotalTaxAppraisal ||
                    TotalTaxAppraisal != null &&
                    TotalTaxAppraisal.Equals(other.TotalTaxAppraisal)
                ) &&
                (
                    HonoraryTickets == other.HonoraryTickets ||
                    HonoraryTickets != null &&
                    HonoraryTickets.SequenceEqual(other.HonoraryTickets)
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
                if (ExecutiveIdCommercialInfo != null)
                    hashCode = hashCode * 59 + ExecutiveIdCommercialInfo.GetHashCode();
                if (DateCommercial != null)
                    hashCode = hashCode * 59 + DateCommercial.GetHashCode();
                if (LegalRepresentatives != null)
                    hashCode = hashCode * 59 + LegalRepresentatives.GetHashCode();
                if (Partners != null)
                    hashCode = hashCode * 59 + Partners.GetHashCode();
                if (Participations != null)
                    hashCode = hashCode * 59 + Participations.GetHashCode();
                if (RealEstate != null)
                    hashCode = hashCode * 59 + RealEstate.GetHashCode();
                if (TotalTaxAppraisal != null)
                    hashCode = hashCode * 59 + TotalTaxAppraisal.GetHashCode();
                if (HonoraryTickets != null)
                    hashCode = hashCode * 59 + HonoraryTickets.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(StatusSituation left, StatusSituation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StatusSituation left, StatusSituation right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}