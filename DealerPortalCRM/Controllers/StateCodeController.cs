using DealerPortalCRM.ViewModels;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
//using Com.CoreLane.Common.Models;
//using Com.CoreLane.ConfigDB.Models.ConnectionTools;
//using Com.CoreLane.StateCode.Models;
//using DealerPortalCRM.DAServiceImpl
//using System.Collections.Generic;

namespace DealerPortalCRM.Controllers
{
    public class StateCodeController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;
        
        public StateCodeController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.StateCode);
            //   db = new StateCodeEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<StateCodeViewModel> GetStateCodeViewModels()
        {
            return scoreManager.StateCodeViewModels;
        }

        // GET: api/StateCodeViewModels/5
        [ResponseType(typeof(StateCodeViewModel))]

        // PUT: api/StateCodeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStateCodeViewModel(StateCodeViewModel StateCodeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(StateCodeViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StateCodeViewModelExists(StateCodeViewModel))
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

        // POST: api/StateCodeViewModels
        [ResponseType(typeof(StateCodeViewModel))]
        public async Task<IHttpActionResult> PostStateCodeViewModel(StateCodeViewModel StateCodeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.StateCodeViewModels.Add(StateCodeViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!StateCodeViewModelExists(StateCodeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = StateCodeViewModel.VehicleMakeModelClassId }, StateCodeViewModel);
        }

        // DELETE: api/StateCodeViewModels/5
        [ResponseType(typeof(StateCodeViewModel))]
        public async Task<IHttpActionResult> DeleteStateCodeViewModel(int id)
        {
            //StateCodeViewModel StateCodeViewModel = await scoreManager.StateCodeViewModels.FindAsync(id);//
            StateCodeViewModel StateCodeViewModel = new StateCodeViewModel();
            if (StateCodeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.StateCodeViewModels.Remove(StateCodeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(StateCodeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StateCodeViewModelExists(StateCodeViewModel StateCodeViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.StateCodeViewModels.Count(e => e.VehicleMakeModelClassId == StateCodeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

