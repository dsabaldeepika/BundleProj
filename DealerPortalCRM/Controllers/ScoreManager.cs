using System;
using System.Linq;
using DealerPortalCRM.ViewModels;

namespace DealerPortalCRM.Controllers
{
    internal class ScoreManager : IScore
    {
        internal IQueryable<AdjustmentRangeViewModel> AdjustmentRangeViewModels;
        private ScoringEngineEntities _db;

        public ScoreManager(ScoringEngineEntities db)
        {
            this._db = db;
        }

        public IQueryable<AdjustmentTypeViewModel> AdjustmentTypeViewModels { get; internal set; }
        public IQueryable<BuyRateViewModel> BuyRateViewModels { get; internal set; }
        public IQueryable<ClassCodeAdjViewModel> ClassCodeAdjViewModels { get; internal set; }
        public IQueryable<DealerDiscountViewModel> DealerDiscountViewModels { get; internal set; }
        public IQueryable<DealerScoreViewModel> DealerScoreViewModels { get; internal set; }
        public IQueryable<DocFeeViewModel> DocFeeViewModels { get; internal set; }
        public IQueryable<ExcessMileageViewModel> ExcessMileageViewModels { get; internal set; }
        public IQueryable<PricingBaseViewModel> PricingBaseViewModels { get; internal set; }
        public IQueryable<ScoringEngineViewModel> ScoringEngineViewModels { get; internal set; }
        public IQueryable<StateAdjustmentViewModel> StateAdjustmentViewModels { get; internal set; }
        public IQueryable<StateCodeViewModel> StateCodeViewModels { get; internal set; }
        public IQueryable<StateFicoRangeViewModel> StateFicoRangeViewModels { get; internal set; }
        public IQueryable<TermCapViewModel> TermCapViewModels { get; internal set; }
        public IQueryable<VehicleClassTypeViewModel> VehicleClassTypeViewModels { get; internal set; }
        public IQueryable<VehicleModelTypeViewModel> VehicleModelTypeViewModels { get; internal set; }
        public IQueryable<WhatIfAnalysisViewModel> WhatIfAnalysisViewModels { get; internal set; }
    }

    internal class ScoringEngineEntities
    {
        private string _connectionString;

        public ScoringEngineEntities(string connectionString)
        {
            this._connectionString = connectionString;
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}