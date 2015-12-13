using System;

namespace DealerPortalCRM.ViewModels
{
    public class SalesRepQueryModel
    {
       public int SalesRepId { get; set; }
       public int ApplicationCount { get; set; }

       public String FirstName { get; set; }

       public String LastName { get; set; }

       public int ApplicationStatus { get; set; }

       public String FullName { get; set; }

 
    }
}