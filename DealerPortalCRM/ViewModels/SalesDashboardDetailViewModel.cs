using System;
using System.Collections.Generic;

namespace DealerPortalCRM.ViewModels
{
    // display  list
    public class SalesDashboardDetailDisplayViewModel
    {
        public List<SalesDashboardDetailViewModel> LiSalesDashboardDetailViewModel { get; set; }
    }

    // each application 
    public class SalesDashboardDetailViewModel
    {
        public Int64 ApplicationId { get; set; }
        public DateTime DateOpened { get; set; }
        public int? SalesRepId { get; set; }
        public string SalesRepName { get; set; }
        public int? DealerId { get; set; }
        public string DealerName { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public DateTime StatusDate { get; set; }
        public string StipStatus { get; set; }                  
        public DateTime LastUpdateDate { get; set; }            
    }

}