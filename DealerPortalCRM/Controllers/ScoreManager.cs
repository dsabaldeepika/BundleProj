namespace DealerPortalCRM.Controllers
{
    internal class ScoreManager : IScore
    {
        private ScoringEngineEntities db;

        public ScoreManager(ScoringEngineEntities db)
        {
            this.db = db;
        }
    }

    internal class ScoringEngineEntities
    {
    }
}