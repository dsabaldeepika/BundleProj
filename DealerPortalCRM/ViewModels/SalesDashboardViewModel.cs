using System;
using System.Collections.Generic;

namespace DealerPortalCRM.ViewModels
{
    // display list
    public class SalesDashboardDisplayViewModel
    {
        public List<SalesDashboardViewModel> LiSalesDashboardViewModel { get; set; }
    }

    // each dashboard group (salesRep or Dealer)
    public class SalesDashboardViewModel
    {

        public int? FundingStatusId { get; set; }
        public int? SalesRepId  { get; set; }
        public string SalesRepName { get; set; }
        public int? DealerId { get; set; }
        public string DealerName { get; set; }
        public string DealerAccountNumber { get; set; }
        public int TotalNew  { get; set; }                      
        public int TotalPending  { get; set; }                  
        public int TotalFunded  { get; set; }                   
        public int TotalOutstandingStips { get; set; }          
        public int TotalCounterOffers { get; set; }             
        public int TotalInProgress { get; set; }                
        public DateTime LastupdateDate { get; set; }            
    }

}