using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DealerPortalCRM.ViewModels
{
    public class DocFeeViewModel
    {

        // AdjustmentType list
        public List<AdjustmentType> LiAdjustmentType { get; set; }

        // AdjustmentType properties
        public int AdjustmentTypeId { get; set; }
        public String AdjustmentTypeType { get; set; }
        public String AdjustmentTypeDisplayName { get; set; }

        //-------------------------------------------------

        // DocFeeClass properties
        public int DocFeeId { get; set; }


        [Required(ErrorMessage = "Min Term is required")]
        [RegularExpression(@"^[0-9]{1,2}$", ErrorMessage = "Min Term must be 2 digit number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:##}")]
        public int DocFeeMinTerm { get; set; }

        [Required(ErrorMessage = "Max Term is required")]
        [RegularExpression(@"^[0-9]{1,2}$", ErrorMessage = "Max Term must be 2 digit number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:##}")]
        public int DocFeeMaxTerm { get; set; }

        [Required(ErrorMessage = "Vehicle Age is required")]
        [RegularExpression(@"\d{1}?", ErrorMessage = "Vehicle Age must be single digit number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#}")]
        public int DocFeeVehicleAge { get; set; }

        [Required(ErrorMessage = "Max Mileage is required")]
        [RegularExpression(@"^[0-9]{1,6}$", ErrorMessage = "Max Mileage must be less than 7 digit number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:######}")]
        public int DocFeeMaxMileage { get; set; }

        [Required(ErrorMessage = "Vehicle Class is required")]
        [RegularExpression(@"\d{1}?", ErrorMessage = "Vehicle Class must be single digit number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:#}")]
        public int DocFeeMaxVehicleClass { get; set; }

        [Required(ErrorMessage = "Doc Fee LT is required")]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Doc Fee LT must be decimal number.")]
        [Range(0, 1000)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C0}")]
        public decimal DocFeeDocFeeLt { get; set; }

        [Required(ErrorMessage = "Doc Fee GT is required")]
        [Range(0, 1000)]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Doc Fee Gt must be decimal number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C0}")]
        public decimal DocFeeDocFeeGe { get; set; }

        public int DocFeeCreatedById { get; set; }
        public int DocFeeModifiedById { get; set; }
        public DateTime DocFeeCreatedDate { get; set; }
        public DateTime DocFeeModifiedDate { get; set; }
        public object VehicleMakeModelClassId { get; internal set; }
    }
}