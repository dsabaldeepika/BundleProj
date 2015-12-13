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
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public ScoringEngineController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<ScoringEngineViewModel> GetScoringEngineViewModels()
        {
            return scoreManager.ScoringEngineViewModels;
        }

        // GET: api/ScoringEngineViewModels/5
        [ResponseType(typeof(ScoringEngineViewModel))]

        // PUT: api/ScoringEngineViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutScoringEngineViewModel(ScoringEngineViewModel ScoringEngineViewModel)
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
                if (!ScoringEngineViewModelExists(ScoringEngineViewModel))
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
        public async Task<IHttpActionResult> PostScoringEngineViewModel(ScoringEngineViewModel ScoringEngineViewModel)
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
                if (!ScoringEngineViewModelExists(ScoringEngineViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = ScoringEngineViewModel.VehicleMakeModelClassId }, ScoringEngineViewModel);
        }

        // DELETE: api/ScoringEngineViewModels/5
        [ResponseType(typeof(ScoringEngineViewModel))]
        public async Task<IHttpActionResult> DeleteScoringEngineViewModel(int id)
        {
            //ScoringEngineViewModel ScoringEngineViewModel = await scoreManager.ScoringEngineViewModels.FindAsync(id);//
            ScoringEngineViewModel ScoringEngineViewModel = new ScoringEngineViewModel();
            if (ScoringEngineViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.ScoringEngineViewModels.Remove(ScoringEngineViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(ScoringEngineViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ScoringEngineViewModelExists(ScoringEngineViewModel ScoringEngineViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.ScoringEngineViewModels.Count(e => e.VehicleMakeModelClassId == ScoringEngineViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

