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
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;

      

        public AdjustmentRangeController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
           // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
         //   db = new ScoringEngineEntities(connectionString);
           // scoreManager = new ScoreManager(db);
        }


        public IQueryable<AdjustmentRangeViewModel> Get()
        {
            return _scoreManager.AdjustmentRangeViewModels;
        }

        // GET: api/AdjustmentRangeViewModels/5
        [ResponseType(typeof(AdjustmentRangeViewModel))]

        // PUT: api/AdjustmentRangeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(AdjustmentRangeViewModel adjustmentRangeViewModel)
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
                if (!AdjustmentRangeViewModelExists(adjustmentRangeViewModel))
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
        public async Task<IHttpActionResult> Post(AdjustmentRangeViewModel adjustmentRangeViewModel)
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
                if (!AdjustmentRangeViewModelExists(adjustmentRangeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = adjustmentRangeViewModel.VehicleMakeModelClassId }, adjustmentRangeViewModel);
        }

        // DELETE: api/AdjustmentRangeViewModels/5
        [ResponseType(typeof(AdjustmentRangeViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //AdjustmentRangeViewModel AdjustmentRangeViewModel = await scoreManager.AdjustmentRangeViewModels.FindAsync(id);

            //to be removed
            AdjustmentRangeViewModel adjustmentRangeViewModel = new AdjustmentRangeViewModel();
            if (adjustmentRangeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.AdjustmentRangeViewModels.Remove(AdjustmentRangeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(adjustmentRangeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdjustmentRangeViewModelExists(AdjustmentRangeViewModel adjustmentRangeViewModel)
        {
            //hardcoded
            return false;
          //  return scoreManager.AdjustmentRangeViewModels.Count(e => e.VehicleMakeModelClassId == AdjustmentRangeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

