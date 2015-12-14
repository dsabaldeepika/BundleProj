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
    public class DealerScoreController : ApiController
    {
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public DealerScoreController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<DealerScoreViewModel> Get()
        {
            return _scoreManager.DealerScoreViewModels;
        }

        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(DealerScoreViewModel dealerScoreViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(DealerScoreViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DealerScoreViewModelExists(dealerScoreViewModel))
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

        // POST: api/DealerScoreViewModels
        [ResponseType(typeof(DealerScoreViewModel))]
        public async Task<IHttpActionResult> Post(DealerScoreViewModel dealerScoreViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.DealerScoreViewModels.Add(DealerScoreViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!DealerScoreViewModelExists(dealerScoreViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = dealerScoreViewModel.VehicleMakeModelClassId }, dealerScoreViewModel);
        }

        // DELETE: api/DealerScoreViewModels/5
        [ResponseType(typeof(DealerScoreViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //DealerScoreViewModel DealerScoreViewModel = await scoreManager.DealerScoreViewModels.FindAsync(id);//
            DealerScoreViewModel dealerScoreViewModel = new DealerScoreViewModel();
            if (dealerScoreViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.DealerScoreViewModels.Remove(DealerScoreViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(dealerScoreViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DealerScoreViewModelExists(DealerScoreViewModel dealerScoreViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.DealerScoreViewModels.Count(e => e.VehicleMakeModelClassId == DealerScoreViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

