using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Portal.Core.Models.ScoringEngine;


namespace DealerPortalCRM.ViewModels
{
    public class TermCapViewModel
    {
         // AdjustmentType list
        public List<AdjustmentType> LiAdjustmentType { get; set; }

        // AdjustmentType properties
        public int AdjustmentTypeId { get; set; }
        public String AdjustmentTypeType { get; set; }
        public String AdjustmentTypeDisplayName { get; set; }

        // TermCap properties

        public int TermCapId { get; set; }

        [Required(ErrorMessage = "Min Finance Amt is required")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C0}")]
        public int TermCapMinFinanceAmt { get; set; }

        [Required(ErrorMessage = "Max Finance Amt is required")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:C0}")]
        public int TermCapMaxFinanceAmt { get; set; }

        [Required(ErrorMessage = "Adjustment Cap is required")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:n0}")]
        public int TermCapAdjustmentCap { get; set; }

        public int TermCapCreatedById { get; set; }
        public int TermCapModifiedById { get; set; }
        public DateTime TermCapCreatedDate { get; set; }
        public DateTime TermCapModifiedDate { get; set; } 
    }
}


