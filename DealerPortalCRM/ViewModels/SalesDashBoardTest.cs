using System;

namespace DealerPortalCRM.ViewModels
{
    public class SalesDashBoardTest
    {

        public int TotalCount { get; set; }

        public int Id { get; set; }

        public int FundingStatusId { get; set; }

        public int DealerId { get; set; }

        public String DealerName { get; set; }

        public int SalesRepId { get; set; }

        public String SalesRep { get; set; }

        public String Description { get; set; }


        public int FundingStatusUnabletoFundTotal { get; set; }


        public int FundingStatusPendingTotal { get; set; }

        public int FundingStatusDocsReceivedTotal { get; set; }

    }
}


/*
   FundingStatus fundingstatus1 = new FundingStatus{ID=1,Description ="Unable to Fund"};
             FundingStatus fundingstatus2 = new FundingStatus{ID=2,Description ="Pending"};
             FundingStatus fundingstatus3 = new FundingStatus {ID=3, Description = "Docs Received" };

*/