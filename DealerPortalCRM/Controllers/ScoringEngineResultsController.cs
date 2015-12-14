using DealerPortalCRM.ViewModels;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
//using Com.CoreLane.Common.Models;
//using Com.CoreLane.ConfigDB.Models.ConnectionTools;
//using Com.CoreLane.ScoringEngine.Models;
//using DealerPortalCRM.DAServiceImpl
//using System.Collections.Generic;

namespace DealerPortalCRM.Controllers
{
    public class ScoringEngineController : ApiController
    {
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public ScoringEngineController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<ScoringEngineViewModel> Get()
        {
            return _scoreManager.ScoringEngineViewModels;
        }

        // GET: api/ScoringEngineViewModels/5
        [ResponseType(typeof(ScoringEngineViewModel))]

        // PUT: api/ScoringEngineViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(ScoringEngineViewModel scoringEngineViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(ScoringEngineViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoringEngineViewModelExists(scoringEngineViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ScoringEngineViewModels
        [ResponseType(typeof(ScoringEngineViewModel))]
        public async Task<IHttpActionResult> Post(ScoringEngineViewModel scoringEngineViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.ScoringEngineViewModels.Add(ScoringEngineViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!ScoringEngineViewModelExists(scoringEngineViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = scoringEngineViewModel.VehicleMakeModelClassId }, scoringEngineViewModel);
        }

        // DELETE: api/ScoringEngineViewModels/5
        [ResponseType(typeof(ScoringEngineViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //ScoringEngineViewModel ScoringEngineViewModel = await scoreManager.ScoringEngineViewModels.FindAsync(id);//
            ScoringEngineViewModel scoringEngineViewModel = new ScoringEngineViewModel();
            if (scoringEngineViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.ScoringEngineViewModels.Remove(ScoringEngineViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(scoringEngineViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ScoringEngineViewModelExists(ScoringEngineViewModel scoringEngineViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.ScoringEngineViewModels.Count(e => e.VehicleMakeModelClassId == ScoringEngineViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

