using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class DealerDiscountViewModel
    {
        // StateCode list
        public List<StateCode> LiStateCode { get; set; }

        // StateCode properties
        public int StateCodeId { get; set; }
        public String StateCodeName { get; set; }
        public String StateCodeAbbreviation { get; set; }
        public String StateCodeSortOrder { get; set; }

        // DealerType list
        public List<DealerType> LiDealerType { get; set; }

        // StateCode properties
        public int DealerTypeId { get; set; }
        public String DealerTypeType { get; set; }

        //Dealer Discount Properties

        [Required]
        public int DealerDiscountId  { get; set; }

        [Required(ErrorMessage = "Dealer Discount is required")]
        [RegularExpression(@"\d+(\.\d{1,6})?", ErrorMessage = "Dealer Discount decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal DealerDiscountDiscount { get; set; }

        public int DealerDiscountCreatedById { get; set; }
        public int DealerDiscountModifiedById { get; set; }
        public DateTime DealerDiscountCreatedDate { get; set; }
        public DateTime DealerDiscountModifiedDate { get; set; }
        public object VehicleMakeModelClassId { get; internal set; }
    }
}
