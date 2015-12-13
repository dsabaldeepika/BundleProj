using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class ClassCodeAdjViewModel
    {
       // VehicleClassType list
        public List<VehicleClassType> LiVehicleClassType { get; set; }

        // VehicleClassType properties
        public int VehicleClassTypeId { get; set; }
        public String VehicleClassTypeName { get; set; }


        //ClassCodeAdj properties

        public int ClassCodeAdjId { get; set; }

        [Required(ErrorMessage = "LTV Cap is required")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:###}")]
        public decimal ClassCodeAdjLtvCap { get; set; }

        [Required(ErrorMessage = "LTV Adjustment is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "LTV Adj decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal ClassCodeAdjLtvAdj { get; set; }

        [Required(ErrorMessage = "Discount Adjustment is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Discount Adjustment decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal ClassCodeAdjDiscountAdj { get; set; }

        [Required(ErrorMessage = "Financed Cap is required")]
        [RegularExpression(@"-?\d+(\.\d{1,2})?")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C2}")]
        public decimal ClassCodeAdjFinancedCap { get; set; }
        
        public int ClassCodeAdjCreatedById { get; set; }
        public int ClassCodeAdjModifiedById { get; set; }
        public DateTime ClassCodeAdjCreatedDate { get; set; }
        public DateTime ClassCodeAdjModifiedDate { get; set; }
        public object VehicleMakeModelClassId { get; internal set; }
    }
}
