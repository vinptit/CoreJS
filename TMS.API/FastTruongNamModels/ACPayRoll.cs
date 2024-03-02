using System;
using System.Collections.Generic;

namespace TMS.API.FastTruongNamModels
{
    public partial class ACPayRoll
    {
        public decimal IDKey { get; set; }
        public decimal? IDLinked { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateApply { get; set; }
        public string ContactID { get; set; }
        public double? ContractSalary { get; set; }
        public int? CWorkingDays { get; set; }
        public int? RWorkingDays { get; set; }
        public int? RHR { get; set; }
        public int? RMin { get; set; }
        public double? Income { get; set; }
        public double? SocialPer { get; set; }
        public double? SocialBaseAmount { get; set; }
        public double? HealthyPer { get; set; }
        public double? HealthyBaseAmount { get; set; }
        public double? UnemplPer { get; set; }
        public double? UnemplBaseAmount { get; set; }
        public double? UnionPer { get; set; }
        public double? UnionBaseAmount { get; set; }
        public int? DeductionPersonel { get; set; }
        public double? DeductionPersonelAmount { get; set; }
        public int? DeductionFamily { get; set; }
        public double? DeductionFamilyAmount { get; set; }
        public double? AllowancePetrol { get; set; }
        public double? AllowanceHP { get; set; }
        public double? AllowanceOthers { get; set; }
        public string AllowanceOthersDescription { get; set; }
        public double? AdjustmentAmountAdd { get; set; }
        public double? TaxAmount { get; set; }
        public double? AdjustmentAmountSub { get; set; }
        public double? ComObiligationSocialPer { get; set; }
        public double? ComObiligationSocialAmount { get; set; }
        public double? ComObiligationHealthyPer { get; set; }
        public double? ComObiligationHealthyAmount { get; set; }
        public double? ComObiligationUnemployPer { get; set; }
        public double? ComObiligationUnemployAmount { get; set; }
        public double? ComObiligationUnionPer { get; set; }
        public double? ComObiligationUnionAmount { get; set; }
        public double? AllowanceCommission { get; set; }
        public double? AllowanceCOthers { get; set; }
        public string AllowanceCOtherNotes { get; set; }
        public double? ComTaxAmount { get; set; }
        public double? ExchangeRate { get; set; }
        public bool? PRDeleted { get; set; }
        public string PRDeletedHistory { get; set; }
        public string UserInput { get; set; }
    }
}
