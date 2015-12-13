using System;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class ExcessMileageViewModel
    {
        public int ExcessMileageId { get; set; }

        [Required(ErrorMessage = "Min Mileage is required")]
        public int ExcessMileageMinMileage { get; set; }

        [Required(ErrorMessage = "Max Mileage is required")]
        public int ExcessMileageMaxMileage { get; set; }

        [Required(ErrorMessage = "LTV Adj is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "LTV Adj decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal ExcessMileageLtvAdj { get; set; }

        [Required(ErrorMessage = "Disc Adj is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Disc Adj decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal ExcessMileageDiscAdj { get; set; }

        [Required(ErrorMessage = "Term Cap is required")]
        [RegularExpression(@"-?\d+(\.\d{1,2})?", ErrorMessage = "Term Cap must be decimal number.")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:###}")]
        public decimal ExcessMileageTermCap { get; set; }

        public bool ExcessMileageIsActive { get; set; }

        public int ExcessMileageCreatedById { get; set; }
        public int ExcessMileageModifiedById { get; set; }
        public DateTime ExcessMileageCreatedDate { get; set; }
        public DateTime ExcessMileageModifiedDate { get; set; }  

    }
}