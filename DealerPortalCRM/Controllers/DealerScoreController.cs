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
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public DealerScoreController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<DealerScoreViewModel> GetDealerScoreViewModels()
        {
            return scoreManager.DealerScoreViewModels;
        }

        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDealerScoreViewModel(DealerScoreViewModel DealerScoreViewModel)
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
                if (!DealerScoreViewModelExists(DealerScoreViewModel))
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
        public async Task<IHttpActionResult> PostDealerScoreViewModel(DealerScoreViewModel DealerScoreViewModel)
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
                if (!DealerScoreViewModelExists(DealerScoreViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = DealerScoreViewModel.VehicleMakeModelClassId }, DealerScoreViewModel);
        }

        // DELETE: api/DealerScoreViewModels/5
        [ResponseType(typeof(DealerScoreViewModel))]
        public async Task<IHttpActionResult> DeleteDealerScoreViewModel(int id)
        {
            //DealerScoreViewModel DealerScoreViewModel = await scoreManager.DealerScoreViewModels.FindAsync(id);//
            DealerScoreViewModel DealerScoreViewModel = new DealerScoreViewModel();
            if (DealerScoreViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.DealerScoreViewModels.Remove(DealerScoreViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(DealerScoreViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DealerScoreViewModelExists(DealerScoreViewModel DealerScoreViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.DealerScoreViewModels.Count(e => e.VehicleMakeModelClassId == DealerScoreViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

