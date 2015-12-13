using System;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class DealerScoreViewModel
    {
        public int DealerScoreId { get; set; }

        [Required(ErrorMessage = "Score is required")]
        public String DealerScoreScore { get; set; }

        [Required(ErrorMessage = "Discount Adjustment is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Discount Adjustment decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal DealerScoreDisAjd { get; set; }

        [Required(ErrorMessage = "LTV Cap is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "LTV Cap decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal DealerScoreLtvCap { get; set; }

        [Required(ErrorMessage = "Minimum Discount is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Minimum Discount decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal DealerScoreMinDisc { get; set; }

        public int DealerScoreCreatedById { get; set; }
        public int DealerScoreModifiedById { get; set; }
        public DateTime DealerScoreCreatedDate { get; set; }
        public DateTime DealerScoreModifiedDate { get; set; }
        public object VehicleMakeModelClassId { get; internal set; }
    }
}
