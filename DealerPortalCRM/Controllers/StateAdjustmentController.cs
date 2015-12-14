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
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public StateAdjustmentController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.StateAdjustment);
            //   db = new StateAdjustmentEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<StateAdjustmentViewModel> GetStateAdjustmentViewModels()
        {
            return _scoreManager.StateAdjustmentViewModels;
        }

        // GET: api/StateAdjustmentViewModels/5
        [ResponseType(typeof(StateAdjustmentViewModel))]

        // PUT: api/StateAdjustmentViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStateAdjustmentViewModel(StateAdjustmentViewModel stateAdjustmentViewModel)
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
                if (!StateAdjustmentViewModelExists(stateAdjustmentViewModel))
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
        public async Task<IHttpActionResult> PostStateAdjustmentViewModel(StateAdjustmentViewModel stateAdjustmentViewModel)
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
                if (!StateAdjustmentViewModelExists(stateAdjustmentViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = stateAdjustmentViewModel.VehicleMakeModelClassId }, stateAdjustmentViewModel);
        }

        // DELETE: api/StateAdjustmentViewModels/5
        [ResponseType(typeof(StateAdjustmentViewModel))]
        public async Task<IHttpActionResult> DeleteStateAdjustmentViewModel(int id)
        {
            //StateAdjustmentViewModel StateAdjustmentViewModel = await scoreManager.StateAdjustmentViewModels.FindAsync(id);//
            StateAdjustmentViewModel stateAdjustmentViewModel = new StateAdjustmentViewModel();
            if (stateAdjustmentViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.StateAdjustmentViewModels.Remove(StateAdjustmentViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(stateAdjustmentViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StateAdjustmentViewModelExists(StateAdjustmentViewModel stateAdjustmentViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.StateAdjustmentViewModels.Count(e => e.VehicleMakeModelClassId == StateAdjustmentViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

