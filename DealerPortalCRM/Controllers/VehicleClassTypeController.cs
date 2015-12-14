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
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;

        public VehicleClassTypeController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<VehicleClassTypeViewModel> Get()
        {
            return _scoreManager.VehicleClassTypeViewModels;
        }

        // GET: api/VehicleClassTypeViewModels/5
        [ResponseType(typeof(VehicleClassTypeViewModel))]

        // PUT: api/VehicleClassTypeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(VehicleClassTypeViewModel vehicleClassTypeViewModel)
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
                if (!VehicleClassTypeViewModelExists(vehicleClassTypeViewModel))
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
        public async Task<IHttpActionResult> Post(VehicleClassTypeViewModel vehicleClassTypeViewModel)
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
                if (!VehicleClassTypeViewModelExists(vehicleClassTypeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = vehicleClassTypeViewModel.VehicleMakeModelClassId }, vehicleClassTypeViewModel);
        }

        // DELETE: api/VehicleClassTypeViewModels/5
        [ResponseType(typeof(VehicleClassTypeViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //VehicleClassTypeViewModel VehicleClassTypeViewModel = await scoreManager.VehicleClassTypeViewModels.FindAsync(id);//
            VehicleClassTypeViewModel vehicleClassTypeViewModel = new VehicleClassTypeViewModel();
            if (vehicleClassTypeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.VehicleClassTypeViewModels.Remove(VehicleClassTypeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(vehicleClassTypeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleClassTypeViewModelExists(VehicleClassTypeViewModel vehicleClassTypeViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.VehicleClassTypeViewModels.Count(e => e.VehicleMakeModelClassId == VehicleClassTypeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

