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
    public class AdjustmentRangeController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;

      

        public AdjustmentRangeController()
        {
            connectionStringProperty = new ConnectionStringProperty();
           // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
         //   db = new ScoringEngineEntities(connectionString);
           // scoreManager = new ScoreManager(db);
        }


        public IQueryable<AdjustmentRangeViewModel> GetAdjustmentRangeViewModels()
        {
            return scoreManager.AdjustmentRangeViewModels;
        }

        // GET: api/AdjustmentRangeViewModels/5
        [ResponseType(typeof(AdjustmentRangeViewModel))]

        // PUT: api/AdjustmentRangeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAdjustmentRangeViewModel(AdjustmentRangeViewModel AdjustmentRangeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            try
            {
                //scoreManager.Entry(AdjustmentRangeViewModel).State = EntityState.Modified;
               // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdjustmentRangeViewModelExists(AdjustmentRangeViewModel))
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

        // POST: api/AdjustmentRangeViewModels
        [ResponseType(typeof(AdjustmentRangeViewModel))]
        public async Task<IHttpActionResult> PostAdjustmentRangeViewModel(AdjustmentRangeViewModel AdjustmentRangeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.AdjustmentRangeViewModels.Add(AdjustmentRangeViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!AdjustmentRangeViewModelExists(AdjustmentRangeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = AdjustmentRangeViewModel.VehicleMakeModelClassId }, AdjustmentRangeViewModel);
        }

        // DELETE: api/AdjustmentRangeViewModels/5
        [ResponseType(typeof(AdjustmentRangeViewModel))]
        public async Task<IHttpActionResult> DeleteAdjustmentRangeViewModel(int id)
        {
            //AdjustmentRangeViewModel AdjustmentRangeViewModel = await scoreManager.AdjustmentRangeViewModels.FindAsync(id);

            //to be removed
            AdjustmentRangeViewModel AdjustmentRangeViewModel = new AdjustmentRangeViewModel();
            if (AdjustmentRangeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.AdjustmentRangeViewModels.Remove(AdjustmentRangeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(AdjustmentRangeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdjustmentRangeViewModelExists(AdjustmentRangeViewModel AdjustmentRangeViewModel)
        {
            //hardcoded
            return false;
          //  return scoreManager.AdjustmentRangeViewModels.Count(e => e.VehicleMakeModelClassId == AdjustmentRangeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

