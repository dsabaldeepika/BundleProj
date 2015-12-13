using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class StateAdjustmentViewModel
    {
        // StateCode list
        public List<StateCode> LiStateCode { get; set; }

        // StateCode properties
        public int StateCodeId { get; set; }
        public String StateCodeName { get; set; }
        public String StateCodeAbbreviation { get; set; }
        public String StateCodeSortOrder { get; set; }

        //StateAdjustment properties

        public int StateAdjustmentId { get; set; }

        [Required(ErrorMessage = "Discount Adjustment is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Discount Adjustment decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal StateAdjustmentDiscountAdj { get; set; }

        [Required(ErrorMessage = "LTV Adjustment is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "LTV Adjustment decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal StateAdjustmentLtvAdj { get; set; }

        [Required(ErrorMessage = "Max State APR is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Max State APR decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal StateAdjustmentMaxStateApr { get; set; }

        [Required(ErrorMessage = "Gap Cap is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C2}")]
        public decimal StateAdjustmentGapCap { get; set; }

        public int StateAdjustmentCreatedById { get; set; }
        public int StateAdjustmentModifiedById { get; set; }
        public DateTime StateAdjustmentCreatedDate { get; set; }
        public DateTime StateAdjustmentModifiedDate { get; set; }
        public object VehicleMakeModelClassId { get; internal set; }
    }
}