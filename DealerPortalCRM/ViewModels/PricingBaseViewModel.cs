using System;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class PricingBaseViewModel
    {
        public int PricingBaseId { get; set; }

        [Required(ErrorMessage = "Min BV is required")]
        [RegularExpression(@"-?\d+(\.\d{1,2})?", ErrorMessage = "Min BV must be decimal number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C0}")]
        public decimal? PricingBaseMinBv { get; set; }

        [Required(ErrorMessage = "Max BV is required")]
        [RegularExpression(@"-?\d+(\.\d{1,2})?", ErrorMessage = "Max BV must be decimal number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C0}")]
        public decimal? PricingBaseMaxBv { get; set; }

        [Required(ErrorMessage = "Min LTV is required")]
        [RegularExpression(@"-?\d+(\.\d{1,2})?", ErrorMessage = "Min LTV must be decimal number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:n2}")]
        public decimal? PricingBaseMinLtv { get; set; }

        [Required(ErrorMessage = "Max LTV is required")]
        [RegularExpression(@"-?\d+(\.\d{1,2})?", ErrorMessage = "Max LTV must be decimal number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:n2}")]
        public decimal? PricingBaseMaxLtv { get; set; }

        [Required(ErrorMessage = "Pricing Rate Discount is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Pricing Rate Discount decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal PricingBasePricingRateDiscount { get; set; }

        public bool PricingBaseIsActive { get; set; }

        public int PricingBaseCreatedById { get; set; }
        public int PricingBaseModifiedById { get; set; }
        public DateTime PricingBaseCreatedDate { get; set; }
        public DateTime PricingBaseModifiedDate { get; set; }  

    }
}