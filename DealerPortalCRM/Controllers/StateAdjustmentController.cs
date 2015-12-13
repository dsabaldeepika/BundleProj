using DealerPortalCRM.ViewModels;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
//using Com.CoreLane.Common.Models;
//using Com.CoreLane.ConfigDB.Models.ConnectionTools;
//using Com.CoreLane.StateAdjustment.Models;
//using DealerPortalCRM.DAServiceImpl
//using System.Collections.Generic;

namespace DealerPortalCRM.Controllers
{
    public class StateAdjustmentController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public StateAdjustmentController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.StateAdjustment);
            //   db = new StateAdjustmentEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<StateAdjustmentViewModel> GetStateAdjustmentViewModels()
        {
            return scoreManager.StateAdjustmentViewModels;
        }

        // GET: api/StateAdjustmentViewModels/5
        [ResponseType(typeof(StateAdjustmentViewModel))]

        // PUT: api/StateAdjustmentViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStateAdjustmentViewModel(StateAdjustmentViewModel StateAdjustmentViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(StateAdjustmentViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StateAdjustmentViewModelExists(StateAdjustmentViewModel))
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

        // POST: api/StateAdjustmentViewModels
        [ResponseType(typeof(StateAdjustmentViewModel))]
        public async Task<IHttpActionResult> PostStateAdjustmentViewModel(StateAdjustmentViewModel StateAdjustmentViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.StateAdjustmentViewModels.Add(StateAdjustmentViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!StateAdjustmentViewModelExists(StateAdjustmentViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = StateAdjustmentViewModel.VehicleMakeModelClassId }, StateAdjustmentViewModel);
        }

        // DELETE: api/StateAdjustmentViewModels/5
        [ResponseType(typeof(StateAdjustmentViewModel))]
        public async Task<IHttpActionResult> DeleteStateAdjustmentViewModel(int id)
        {
            //StateAdjustmentViewModel StateAdjustmentViewModel = await scoreManager.StateAdjustmentViewModels.FindAsync(id);//
            StateAdjustmentViewModel StateAdjustmentViewModel = new StateAdjustmentViewModel();
            if (StateAdjustmentViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.StateAdjustmentViewModels.Remove(StateAdjustmentViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(StateAdjustmentViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StateAdjustmentViewModelExists(StateAdjustmentViewModel StateAdjustmentViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.StateAdjustmentViewModels.Count(e => e.VehicleMakeModelClassId == StateAdjustmentViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

