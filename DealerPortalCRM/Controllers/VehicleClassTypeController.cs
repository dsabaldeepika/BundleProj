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
    public class VehicleClassTypeController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;

        public VehicleClassTypeController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<VehicleClassTypeViewModel> GetVehicleClassTypeViewModels()
        {
            return scoreManager.VehicleClassTypeViewModels;
        }

        // GET: api/VehicleClassTypeViewModels/5
        [ResponseType(typeof(VehicleClassTypeViewModel))]

        // PUT: api/VehicleClassTypeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVehicleClassTypeViewModel(VehicleClassTypeViewModel VehicleClassTypeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(VehicleClassTypeViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleClassTypeViewModelExists(VehicleClassTypeViewModel))
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

        // POST: api/VehicleClassTypeViewModels
        [ResponseType(typeof(VehicleClassTypeViewModel))]
        public async Task<IHttpActionResult> PostVehicleClassTypeViewModel(VehicleClassTypeViewModel VehicleClassTypeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.VehicleClassTypeViewModels.Add(VehicleClassTypeViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!VehicleClassTypeViewModelExists(VehicleClassTypeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = VehicleClassTypeViewModel.VehicleMakeModelClassId }, VehicleClassTypeViewModel);
        }

        // DELETE: api/VehicleClassTypeViewModels/5
        [ResponseType(typeof(VehicleClassTypeViewModel))]
        public async Task<IHttpActionResult> DeleteVehicleClassTypeViewModel(int id)
        {
            //VehicleClassTypeViewModel VehicleClassTypeViewModel = await scoreManager.VehicleClassTypeViewModels.FindAsync(id);//
            VehicleClassTypeViewModel VehicleClassTypeViewModel = new VehicleClassTypeViewModel();
            if (VehicleClassTypeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.VehicleClassTypeViewModels.Remove(VehicleClassTypeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(VehicleClassTypeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleClassTypeViewModelExists(VehicleClassTypeViewModel VehicleClassTypeViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.VehicleClassTypeViewModels.Count(e => e.VehicleMakeModelClassId == VehicleClassTypeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

