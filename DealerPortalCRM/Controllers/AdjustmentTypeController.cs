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
    public class AdjustmentTypeController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public AdjustmentTypeController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<AdjustmentTypeViewModel> GetAdjustmentTypeViewModels()
        {
            return scoreManager.AdjustmentTypeViewModels;
        }

        // GET: api/AdjustmentTypeViewModels/5
        [ResponseType(typeof(AdjustmentTypeViewModel))]

        // PUT: api/AdjustmentTypeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAdjustmentTypeViewModel(AdjustmentTypeViewModel AdjustmentTypeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(AdjustmentTypeViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdjustmentTypeViewModelExists(AdjustmentTypeViewModel))
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

        // POST: api/AdjustmentTypeViewModels
        [ResponseType(typeof(AdjustmentTypeViewModel))]
        public async Task<IHttpActionResult> PostAdjustmentTypeViewModel(AdjustmentTypeViewModel AdjustmentTypeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.AdjustmentTypeViewModels.Add(AdjustmentTypeViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!AdjustmentTypeViewModelExists(AdjustmentTypeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = AdjustmentTypeViewModel.VehicleMakeModelClassId }, AdjustmentTypeViewModel);
        }

        // DELETE: api/AdjustmentTypeViewModels/5
        [ResponseType(typeof(AdjustmentTypeViewModel))]
        public async Task<IHttpActionResult> DeleteAdjustmentTypeViewModel(int id)
        {
            //AdjustmentTypeViewModel AdjustmentTypeViewModel = await scoreManager.AdjustmentTypeViewModels.FindAsync(id);//
            AdjustmentTypeViewModel AdjustmentTypeViewModel = new AdjustmentTypeViewModel();
            if (AdjustmentTypeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.AdjustmentTypeViewModels.Remove(AdjustmentTypeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(AdjustmentTypeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdjustmentTypeViewModelExists(AdjustmentTypeViewModel AdjustmentTypeViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.AdjustmentTypeViewModels.Count(e => e.VehicleMakeModelClassId == AdjustmentTypeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

