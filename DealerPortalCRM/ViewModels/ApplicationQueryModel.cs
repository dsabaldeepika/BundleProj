using System;

namespace DealerPortalCRM.ViewModels
{
    public class ApplicationQueryModel
    {

        public int Id { get; set; }
        public int ApplicationNumber  { get; set; }
        public String SalesRepName { get; set; }

        public String DealerName { get; set; }


        public String FundingStatus { get; set; }


        public String DecisionStatus { get; set; }


        public DateTime ApplicationEnteredDate { get; set; }




       



    }
}