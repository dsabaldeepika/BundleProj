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
    public class VehicleModelTypeController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;

        public VehicleModelTypeController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }
        public IQueryable<VehicleModelTypeViewModel> GetVehicleModelTypeViewModels()
        {
            return scoreManager.VehicleModelTypeViewModels;
        }

        // GET: api/VehicleModelTypeViewModels/5
        [ResponseType(typeof(VehicleModelTypeViewModel))]

        // PUT: api/VehicleModelTypeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVehicleModelTypeViewModel(VehicleModelTypeViewModel VehicleModelTypeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(VehicleModelTypeViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleModelTypeViewModelExists(VehicleModelTypeViewModel))
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

        // POST: api/VehicleModelTypeViewModels
        [ResponseType(typeof(VehicleModelTypeViewModel))]
        public async Task<IHttpActionResult> PostVehicleModelTypeViewModel(VehicleModelTypeViewModel VehicleModelTypeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.VehicleModelTypeViewModels.Add(VehicleModelTypeViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!VehicleModelTypeViewModelExists(VehicleModelTypeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = VehicleModelTypeViewModel.VehicleMakeModelClassId }, VehicleModelTypeViewModel);
        }

        // DELETE: api/VehicleModelTypeViewModels/5
        [ResponseType(typeof(VehicleModelTypeViewModel))]
        public async Task<IHttpActionResult> DeleteVehicleModelTypeViewModel(int id)
        {
            //VehicleModelTypeViewModel VehicleModelTypeViewModel = await scoreManager.VehicleModelTypeViewModels.FindAsync(id);//
            VehicleModelTypeViewModel VehicleModelTypeViewModel = new VehicleModelTypeViewModel();
            if (VehicleModelTypeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.VehicleModelTypeViewModels.Remove(VehicleModelTypeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(VehicleModelTypeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleModelTypeViewModelExists(VehicleModelTypeViewModel VehicleModelTypeViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.VehicleModelTypeViewModels.Count(e => e.VehicleMakeModelClassId == VehicleModelTypeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

