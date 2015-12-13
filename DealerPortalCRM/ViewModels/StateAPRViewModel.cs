using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DealerPortalCRM.ViewModels
{
    public class StateAprViewModel
    {
        // StateCode list
        public List<StateCode> LiStateCode { get; set; }

        // StateCode properties
        public int StateCodeId { get; set; }
        public String StateCodeName { get; set; }
        public String StateCodeAbbreviation { get; set; }
        public String StateCodeSortOrder { get; set; }

        //StateAPR properties

        public int StateAprid { get; set; }

        [Required(ErrorMessage = "Fico Score is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###}")]
        public decimal StateAprFicoScore { get; set; }

        [Required(ErrorMessage = "Minimum APR is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Minimum APR decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal StateAprMinApr { get; set; }

        [Required(ErrorMessage = "Maximum APR is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "Maximum APR decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal StateAprMaxApr { get; set; }

        public int StateAprCreatedById { get; set; }
        public int StateAprModifiedById { get; set; }
        public DateTime StateAprCreatedDate { get; set; }
        public DateTime StateAprModifiedDate { get; set; }   
    }
}