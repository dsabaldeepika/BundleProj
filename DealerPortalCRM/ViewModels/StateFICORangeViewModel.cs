
﻿using System;
using System.Collections.Generic;
﻿using System.ComponentModel.DataAnnotations;
﻿using Portal.Core.Models.ScoringEngine;

namespace DealerPortalCRM.ViewModels
{
    public class StateFicoRangeViewModel
    {
        // StateCode list
        public List<StateCode> LiStateCode { get; set; }

        // StateCode properties
        public int StateCodeId { get; set; }
        public String StateCodeName { get; set; }
        public String StateCodeAbbreviation { get; set; }
        public String StateCodeSortOrder { get; set; }

     //StateFICORange properties

        public int StateFicoRangeId {get; set;}

        [Required(ErrorMessage = "Minimum FICO Score is required")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:###}")]
        public int StateFicoRangeFicoScoreMin { get; set; }

        [Required(ErrorMessage = "Maximum FICO Score is required")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:###}")]
        public int StateFicoRangeFicoScoreMax { get; set; }

        [Required(ErrorMessage = "FICO Score APR is required")]
        [RegularExpression(@"-?\d+(\.\d{1,6})?", ErrorMessage = "FICO Score APR decimal cannot exceed 6 digits.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:n6}")]
        public decimal StateFicoRangeMinApr { get; set; }

        public int StateFicoRangeCreatedById { get; set; }
        public int StateFicoRangeModifiedById { get; set; }
        public DateTime StateFicoRangeCreatedDate { get; set; }
        public DateTime StateFicoRangeModifiedDate { get; set; }   

    }
}

