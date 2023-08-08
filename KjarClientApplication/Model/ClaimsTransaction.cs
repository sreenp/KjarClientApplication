using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.myspace.triagesample
{
    /// <summary>
    /// ClaimsTransaction
    /// </summary>
    [DataContract]
    public partial class ClaimsTransaction : IEquatable<ClaimsTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimsTransaction" /> class.
        /// </summary>
        /// <param name="submissionId">submissionId (required).</param>
        /// <param name="icosClaimId">icosClaimId (required).</param>
        /// <param name="lossLocation">lossLocation.</param>
        /// <param name="brokerClaimReference">brokerClaimReference.</param>
        /// <param name="brokerPolicyReference">brokerPolicyReference.</param>
        /// <param name="brokerContractSectionReference">brokerContractSectionReference.</param>
        /// <param name="adviceTypeCode">adviceTypeCode.</param>
        /// <param name="lossCurrency">lossCurrency.</param>
        /// <param name="market">market.</param>
        /// <param name="originalCurrency">originalCurrency.</param>
        /// <param name="transactionType">transactionType.</param>
        /// <param name="transactionSequence">transactionSequence.</param>
        /// <param name="transactionReference">transactionReference.</param>
        /// <param name="claimStatus">claimStatus.</param>
        /// <param name="transactionStatus">transactionStatus.</param>
        /// <param name="bureauLead">bureauLead.</param>
        /// <param name="highLevelClassOfBusiness">highLevelClassOfBusiness.</param>
        /// <param name="lossEventName">lossEventName.</param>
        /// <param name="brokerPartyId">brokerPartyId.</param>
        /// <param name="carrierPartyId">carrierPartyId.</param>
        /// <param name="insurerPartyId">insurerPartyId.</param>
        /// <param name="estimatedLossAmount">Settlement amount.</param>
        /// <param name="transactionUUID">transactionUUID.</param>
        /// <param name="policydateFrom">policydateFrom.</param>
        /// <param name="lossdate">lossdate.</param>
        /// <param name="created">created.</param>
        /// <param name="updated">updated.</param>
        public ClaimsTransaction(Guid? submissionId = default(Guid?), Guid? icosClaimId = default(Guid?), string lossLocation = default(string), string brokerClaimReference = default(string), string brokerPolicyReference = default(string), string brokerContractSectionReference = default(string), string adviceTypeCode = default(string), string lossCurrency = default(string), string market = default(string), string originalCurrency = default(string), string transactionType = default(string), string transactionSequence = default(string), string transactionReference = default(string), string claimStatus = default(string), string transactionStatus = default(string), string bureauLead = default(string), string highLevelClassOfBusiness = default(string), string lossEventName = default(string), Guid? brokerPartyId = default(Guid?), Guid? carrierPartyId = default(Guid?), Guid? insurerPartyId = default(Guid?), decimal? estimatedLossAmount = default(decimal?), Guid? transactionUUID = default(Guid?), DateTime? policydateFrom = default(DateTime?), DateTime? lossdate = default(DateTime?), DateTime? created = default(DateTime?), DateTime? updated = default(DateTime?))
        {
            // to ensure "submissionId" is required (not null)
            if (submissionId == null)
            {
                throw new InvalidDataException("submissionId is a required property for ClaimsTransaction and cannot be null");
            }
            else
            {
                this.SubmissionId = submissionId;
            }
            // to ensure "icosClaimId" is required (not null)
            if (icosClaimId == null)
            {
                throw new InvalidDataException("icosClaimId is a required property for ClaimsTransaction and cannot be null");
            }
            else
            {
                this.IcosClaimId = icosClaimId;
            }
            this.LossLocation = lossLocation;
            this.BrokerClaimReference = brokerClaimReference;
            this.BrokerPolicyReference = brokerPolicyReference;
            this.BrokerContractSectionReference = brokerContractSectionReference;
            this.AdviceTypeCode = adviceTypeCode;
            this.LossCurrency = lossCurrency;
            this.Market = market;
            this.OriginalCurrency = originalCurrency;
            this.TransactionType = transactionType;
            this.TransactionSequence = transactionSequence;
            this.TransactionReference = transactionReference;
            this.ClaimStatus = claimStatus;
            this.TransactionStatus = transactionStatus;
            this.BureauLead = bureauLead;
            this.HighLevelClassOfBusiness = highLevelClassOfBusiness;
            this.LossEventName = lossEventName;
            this.BrokerPartyId = brokerPartyId;
            this.CarrierPartyId = carrierPartyId;
            this.InsurerPartyId = insurerPartyId;
            this.EstimatedLossAmount = estimatedLossAmount;
            this.TransactionUUID = transactionUUID;
            this.PolicydateFrom = policydateFrom;
            this.Lossdate = lossdate;
            this.Created = created;
            this.Updated = updated;
        }
        public ClaimsTransaction()
        {

        }
        /// <summary>
        /// Gets or Sets SubmissionId
        /// </summary>
        [DataMember(Name = "submissionId", EmitDefaultValue = false)]
        public Guid? SubmissionId { get; set; }

        /// <summary>
        /// Gets or Sets IcosClaimId
        /// </summary>
        [DataMember(Name = "icosClaimId", EmitDefaultValue = false)]
        public Guid? IcosClaimId { get; set; }

        /// <summary>
        /// Gets or Sets LossLocation
        /// </summary>
        [DataMember(Name = "lossLocation", EmitDefaultValue = false)]
        public string LossLocation { get; set; }

        /// <summary>
        /// Gets or Sets BrokerClaimReference
        /// </summary>
        [DataMember(Name = "brokerClaimReference", EmitDefaultValue = false)]
        public string BrokerClaimReference { get; set; }

        /// <summary>
        /// Gets or Sets BrokerPolicyReference
        /// </summary>
        [DataMember(Name = "brokerPolicyReference", EmitDefaultValue = false)]
        public string BrokerPolicyReference { get; set; }

        /// <summary>
        /// Gets or Sets BrokerContractSectionReference
        /// </summary>
        [DataMember(Name = "brokerContractSectionReference", EmitDefaultValue = false)]
        public string BrokerContractSectionReference { get; set; }

        /// <summary>
        /// Gets or Sets AdviceTypeCode
        /// </summary>
        [DataMember(Name = "adviceTypeCode", EmitDefaultValue = false)]
        public string AdviceTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets LossCurrency
        /// </summary>
        [DataMember(Name = "lossCurrency", EmitDefaultValue = false)]
        public string LossCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Market
        /// </summary>
        [DataMember(Name = "market", EmitDefaultValue = false)]
        public string Market { get; set; }

        /// <summary>
        /// Gets or Sets OriginalCurrency
        /// </summary>
        [DataMember(Name = "originalCurrency", EmitDefaultValue = false)]
        public string OriginalCurrency { get; set; }

        /// <summary>
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name = "transactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets TransactionSequence
        /// </summary>
        [DataMember(Name = "transactionSequence", EmitDefaultValue = false)]
        public string TransactionSequence { get; set; }

        /// <summary>
        /// Gets or Sets TransactionReference
        /// </summary>
        [DataMember(Name = "transactionReference", EmitDefaultValue = false)]
        public string TransactionReference { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatus
        /// </summary>
        [DataMember(Name = "claimStatus", EmitDefaultValue = false)]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// Gets or Sets TransactionStatus
        /// </summary>
        [DataMember(Name = "transactionStatus", EmitDefaultValue = false)]
        public string TransactionStatus { get; set; }

        /// <summary>
        /// Gets or Sets BureauLead
        /// </summary>
        [DataMember(Name = "bureauLead", EmitDefaultValue = false)]
        public string BureauLead { get; set; }

        /// <summary>
        /// Gets or Sets HighLevelClassOfBusiness
        /// </summary>
        [DataMember(Name = "highLevelClassOfBusiness", EmitDefaultValue = false)]
        public string HighLevelClassOfBusiness { get; set; }

        /// <summary>
        /// Gets or Sets LossEventName
        /// </summary>
        [DataMember(Name = "lossEventName", EmitDefaultValue = false)]
        public string LossEventName { get; set; }

        /// <summary>
        /// Gets or Sets BrokerPartyId
        /// </summary>
        [DataMember(Name = "brokerPartyId", EmitDefaultValue = false)]
        public Guid? BrokerPartyId { get; set; }

        /// <summary>
        /// Gets or Sets CarrierPartyId
        /// </summary>
        [DataMember(Name = "carrierPartyId", EmitDefaultValue = false)]
        public Guid? CarrierPartyId { get; set; }

        /// <summary>
        /// Gets or Sets InsurerPartyId
        /// </summary>
        [DataMember(Name = "insurerPartyId", EmitDefaultValue = false)]
        public Guid? InsurerPartyId { get; set; }

        /// <summary>
        /// Settlement amount
        /// </summary>
        /// <value>Settlement amount</value>
        [DataMember(Name = "estimatedLossAmount", EmitDefaultValue = false)]
        public decimal? EstimatedLossAmount { get; set; }

        /// <summary>
        /// Gets or Sets TransactionUUID
        /// </summary>
        [DataMember(Name = "transactionUUID", EmitDefaultValue = false)]
        public Guid? TransactionUUID { get; set; }

        /// <summary>
        /// Gets or Sets PolicydateFrom
        /// </summary>
        [DataMember(Name = "policydateFrom", EmitDefaultValue = false)]
        public DateTime? PolicydateFrom { get; set; }

        /// <summary>
        /// Gets or Sets Lossdate
        /// </summary>
        [DataMember(Name = "lossdate", EmitDefaultValue = false)]
        public DateTime? Lossdate { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClaimsTransaction {\n");
            sb.Append("  SubmissionId: ").Append(SubmissionId).Append("\n");
            sb.Append("  IcosClaimId: ").Append(IcosClaimId).Append("\n");
            sb.Append("  LossLocation: ").Append(LossLocation).Append("\n");
            sb.Append("  BrokerClaimReference: ").Append(BrokerClaimReference).Append("\n");
            sb.Append("  BrokerPolicyReference: ").Append(BrokerPolicyReference).Append("\n");
            sb.Append("  BrokerContractSectionReference: ").Append(BrokerContractSectionReference).Append("\n");
            sb.Append("  AdviceTypeCode: ").Append(AdviceTypeCode).Append("\n");
            sb.Append("  LossCurrency: ").Append(LossCurrency).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  OriginalCurrency: ").Append(OriginalCurrency).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  TransactionSequence: ").Append(TransactionSequence).Append("\n");
            sb.Append("  TransactionReference: ").Append(TransactionReference).Append("\n");
            sb.Append("  ClaimStatus: ").Append(ClaimStatus).Append("\n");
            sb.Append("  TransactionStatus: ").Append(TransactionStatus).Append("\n");
            sb.Append("  BureauLead: ").Append(BureauLead).Append("\n");
            sb.Append("  HighLevelClassOfBusiness: ").Append(HighLevelClassOfBusiness).Append("\n");
            sb.Append("  LossEventName: ").Append(LossEventName).Append("\n");
            sb.Append("  BrokerPartyId: ").Append(BrokerPartyId).Append("\n");
            sb.Append("  CarrierPartyId: ").Append(CarrierPartyId).Append("\n");
            sb.Append("  InsurerPartyId: ").Append(InsurerPartyId).Append("\n");
            sb.Append("  EstimatedLossAmount: ").Append(EstimatedLossAmount).Append("\n");
            sb.Append("  TransactionUUID: ").Append(TransactionUUID).Append("\n");
            sb.Append("  PolicydateFrom: ").Append(PolicydateFrom).Append("\n");
            sb.Append("  Lossdate: ").Append(Lossdate).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClaimsTransaction);
        }

        /// <summary>
        /// Returns true if ClaimsTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of ClaimsTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClaimsTransaction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SubmissionId == input.SubmissionId ||
                    (this.SubmissionId != null &&
                    this.SubmissionId.Equals(input.SubmissionId))
                ) &&
                (
                    this.IcosClaimId == input.IcosClaimId ||
                    (this.IcosClaimId != null &&
                    this.IcosClaimId.Equals(input.IcosClaimId))
                ) &&
                (
                    this.LossLocation == input.LossLocation ||
                    (this.LossLocation != null &&
                    this.LossLocation.Equals(input.LossLocation))
                ) &&
                (
                    this.BrokerClaimReference == input.BrokerClaimReference ||
                    (this.BrokerClaimReference != null &&
                    this.BrokerClaimReference.Equals(input.BrokerClaimReference))
                ) &&
                (
                    this.BrokerPolicyReference == input.BrokerPolicyReference ||
                    (this.BrokerPolicyReference != null &&
                    this.BrokerPolicyReference.Equals(input.BrokerPolicyReference))
                ) &&
                (
                    this.BrokerContractSectionReference == input.BrokerContractSectionReference ||
                    (this.BrokerContractSectionReference != null &&
                    this.BrokerContractSectionReference.Equals(input.BrokerContractSectionReference))
                ) &&
                (
                    this.AdviceTypeCode == input.AdviceTypeCode ||
                    (this.AdviceTypeCode != null &&
                    this.AdviceTypeCode.Equals(input.AdviceTypeCode))
                ) &&
                (
                    this.LossCurrency == input.LossCurrency ||
                    (this.LossCurrency != null &&
                    this.LossCurrency.Equals(input.LossCurrency))
                ) &&
                (
                    this.Market == input.Market ||
                    (this.Market != null &&
                    this.Market.Equals(input.Market))
                ) &&
                (
                    this.OriginalCurrency == input.OriginalCurrency ||
                    (this.OriginalCurrency != null &&
                    this.OriginalCurrency.Equals(input.OriginalCurrency))
                ) &&
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    this.TransactionSequence == input.TransactionSequence ||
                    (this.TransactionSequence != null &&
                    this.TransactionSequence.Equals(input.TransactionSequence))
                ) &&
                (
                    this.TransactionReference == input.TransactionReference ||
                    (this.TransactionReference != null &&
                    this.TransactionReference.Equals(input.TransactionReference))
                ) &&
                (
                    this.ClaimStatus == input.ClaimStatus ||
                    (this.ClaimStatus != null &&
                    this.ClaimStatus.Equals(input.ClaimStatus))
                ) &&
                (
                    this.TransactionStatus == input.TransactionStatus ||
                    (this.TransactionStatus != null &&
                    this.TransactionStatus.Equals(input.TransactionStatus))
                ) &&
                (
                    this.BureauLead == input.BureauLead ||
                    (this.BureauLead != null &&
                    this.BureauLead.Equals(input.BureauLead))
                ) &&
                (
                    this.HighLevelClassOfBusiness == input.HighLevelClassOfBusiness ||
                    (this.HighLevelClassOfBusiness != null &&
                    this.HighLevelClassOfBusiness.Equals(input.HighLevelClassOfBusiness))
                ) &&
                (
                    this.LossEventName == input.LossEventName ||
                    (this.LossEventName != null &&
                    this.LossEventName.Equals(input.LossEventName))
                ) &&
                (
                    this.BrokerPartyId == input.BrokerPartyId ||
                    (this.BrokerPartyId != null &&
                    this.BrokerPartyId.Equals(input.BrokerPartyId))
                ) &&
                (
                    this.CarrierPartyId == input.CarrierPartyId ||
                    (this.CarrierPartyId != null &&
                    this.CarrierPartyId.Equals(input.CarrierPartyId))
                ) &&
                (
                    this.InsurerPartyId == input.InsurerPartyId ||
                    (this.InsurerPartyId != null &&
                    this.InsurerPartyId.Equals(input.InsurerPartyId))
                ) &&
                (
                    this.EstimatedLossAmount == input.EstimatedLossAmount ||
                    (this.EstimatedLossAmount != null &&
                    this.EstimatedLossAmount.Equals(input.EstimatedLossAmount))
                ) &&
                (
                    this.TransactionUUID == input.TransactionUUID ||
                    (this.TransactionUUID != null &&
                    this.TransactionUUID.Equals(input.TransactionUUID))
                ) &&
                (
                    this.PolicydateFrom == input.PolicydateFrom ||
                    (this.PolicydateFrom != null &&
                    this.PolicydateFrom.Equals(input.PolicydateFrom))
                ) &&
                (
                    this.Lossdate == input.Lossdate ||
                    (this.Lossdate != null &&
                    this.Lossdate.Equals(input.Lossdate))
                ) &&
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) &&
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
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
                int hashCode = 41;
                if (this.SubmissionId != null)
                    hashCode = hashCode * 59 + this.SubmissionId.GetHashCode();
                if (this.IcosClaimId != null)
                    hashCode = hashCode * 59 + this.IcosClaimId.GetHashCode();
                if (this.LossLocation != null)
                    hashCode = hashCode * 59 + this.LossLocation.GetHashCode();
                if (this.BrokerClaimReference != null)
                    hashCode = hashCode * 59 + this.BrokerClaimReference.GetHashCode();
                if (this.BrokerPolicyReference != null)
                    hashCode = hashCode * 59 + this.BrokerPolicyReference.GetHashCode();
                if (this.BrokerContractSectionReference != null)
                    hashCode = hashCode * 59 + this.BrokerContractSectionReference.GetHashCode();
                if (this.AdviceTypeCode != null)
                    hashCode = hashCode * 59 + this.AdviceTypeCode.GetHashCode();
                if (this.LossCurrency != null)
                    hashCode = hashCode * 59 + this.LossCurrency.GetHashCode();
                if (this.Market != null)
                    hashCode = hashCode * 59 + this.Market.GetHashCode();
                if (this.OriginalCurrency != null)
                    hashCode = hashCode * 59 + this.OriginalCurrency.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.TransactionSequence != null)
                    hashCode = hashCode * 59 + this.TransactionSequence.GetHashCode();
                if (this.TransactionReference != null)
                    hashCode = hashCode * 59 + this.TransactionReference.GetHashCode();
                if (this.ClaimStatus != null)
                    hashCode = hashCode * 59 + this.ClaimStatus.GetHashCode();
                if (this.TransactionStatus != null)
                    hashCode = hashCode * 59 + this.TransactionStatus.GetHashCode();
                if (this.BureauLead != null)
                    hashCode = hashCode * 59 + this.BureauLead.GetHashCode();
                if (this.HighLevelClassOfBusiness != null)
                    hashCode = hashCode * 59 + this.HighLevelClassOfBusiness.GetHashCode();
                if (this.LossEventName != null)
                    hashCode = hashCode * 59 + this.LossEventName.GetHashCode();
                if (this.BrokerPartyId != null)
                    hashCode = hashCode * 59 + this.BrokerPartyId.GetHashCode();
                if (this.CarrierPartyId != null)
                    hashCode = hashCode * 59 + this.CarrierPartyId.GetHashCode();
                if (this.InsurerPartyId != null)
                    hashCode = hashCode * 59 + this.InsurerPartyId.GetHashCode();
                if (this.EstimatedLossAmount != null)
                    hashCode = hashCode * 59 + this.EstimatedLossAmount.GetHashCode();
                if (this.TransactionUUID != null)
                    hashCode = hashCode * 59 + this.TransactionUUID.GetHashCode();
                if (this.PolicydateFrom != null)
                    hashCode = hashCode * 59 + this.PolicydateFrom.GetHashCode();
                if (this.Lossdate != null)
                    hashCode = hashCode * 59 + this.Lossdate.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
