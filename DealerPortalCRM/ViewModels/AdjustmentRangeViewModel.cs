using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Portal.Core.Models.ScoringEngine;

namespace DealerPortalCRM.ViewModels
{
    public class AdjustmentRangeViewModel
    {
        // AdjustmentType list
        public List<AdjustmentType> LiAdjustmentType { get; set; }

        // AdjustmentType properties
        public int AdjustmentTypeId { get; set; }
        public String AdjustmentTypeType { get; set; }
        public String AdjustmentTypeDisplayName { get; set; }

        // AdjustmentRange properties
        public int AdjustmentRangeId { get; set; }
        [Required(ErrorMessage = "MinTerm is required")]
        [RegularExpression(@"\d+(\.\d{1,4})?", ErrorMessage = "MinTerm decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n4}")]
        public decimal MinTerm { get; set; }
        [Required(ErrorMessage = "MaxTerm is required")]
        [RegularExpression(@"\d+(\.\d{1,4})?", ErrorMessage = "MaxTerm decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n4}")]
        public decimal MaxTerm { get; set; }
        [Required(ErrorMessage = "Adjustment Discount is required")]
        [RegularExpression(@"\d+(\.\d{1,4})?", ErrorMessage = "Adjustment Discount decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n4}")]
        public decimal AdjustmentDiscount { get; set; }
        public int AdjustmentRangeCreatedById { get; set; }
        public int AdjustmentRangeModifiedById { get; set; }
        public DateTime AdjustmentRangeCreatedDate { get; set; }
        public DateTime AdjustmentRangeModifiedDate { get; set; }
    }
}