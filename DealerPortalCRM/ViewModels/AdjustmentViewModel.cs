using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class AdjustmentViewModel
    {
        // AdjustmentType list
        
        public List<AdjustmentType> LiAdjustmentType { get; set; }

        // AdjustmentType properties
        public int AdjustmentTypeId { get; set; }
        public string AdjustmentTypeType { get; set; }
        public string AdjustmentTypeDisplayName { get; set; }

        // Adjustment properties
        public int AdjustmentId { get; set; }

        [Required(ErrorMessage = "Adjustment Number is required")]
        [StringLength(500, ErrorMessage = "Adjustment Number cannot be longer than 500 characters.")]
        public string AdjustmentNumber { get; set; }

        [Required(ErrorMessage = "Adjustment Discount is required")]
        [RegularExpression(@"\d+(\.\d{1,6})?", ErrorMessage = "Adjustment Discount decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal AdjustmentDiscount { get; set; }

        public bool AdjustmentIsActive { get; set; }
        public int AdjustmentCreatedById { get; set; }
        public int AdjustmentModifiedById { get; set; }
        public DateTime AdjustmentCreatedDate { get; set; }
        public DateTime AdjustmentModifiedDate { get; set; }
    }
}