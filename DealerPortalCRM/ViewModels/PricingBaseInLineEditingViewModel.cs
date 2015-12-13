namespace DealerPortalCRM.ViewModels
{
    public class PricingBaseInLineEditingViewModel
    {
        public int PricingBaseId { get; set; }
        public string PricingBaseMinBv { get; set; }
        public string PricingBaseMaxBv { get; set; }
        public string PricingBaseMinLtv { get; set; }
        public string PricingBaseMaxLtv { get; set; }
        public string PricingBasePricingRateDiscount { get; set; }
        public bool IsActive { get; set; }
    }
}