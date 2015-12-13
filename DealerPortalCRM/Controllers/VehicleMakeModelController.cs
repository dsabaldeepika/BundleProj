using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DealerPortalCRM.Models;
using DealerPortalCRM.ViewModels;

namespace DealerPortalCRM.Controllers
{
    public class VehicleMakeModelController : ApiController
    {
        private DealerPortalCRMContext db = new DealerPortalCRMContext();

        // GET: api/VehicleMakeModelClassViewModels
        public IQueryable<VehicleMakeModelClassViewModel> Get()
        {
            return db.VehicleMakeModelClassViewModels;
        }

      // PUT: api/VehicleMakeModelClassViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(VehicleMakeModelClassViewModel vehicleMakeModelClassViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entry(vehicleMakeModelClassViewModel).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleMakeModelClassViewModelExists(vehicleMakeModelClassViewModel))  
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

        // POST: api/VehicleMakeModelClassViewModels
        [ResponseType(typeof(VehicleMakeModelClassViewModel))]
        public async Task<IHttpActionResult> Post(VehicleMakeModelClassViewModel vehicleMakeModelClassViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                db.VehicleMakeModelClassViewModels.Add(vehicleMakeModelClassViewModel);
                await db.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!VehicleMakeModelClassViewModelExists(vehicleMakeModelClassViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            
            return CreatedAtRoute("DefaultApi", new { id = vehicleMakeModelClassViewModel.VehicleMakeModelClassId }, vehicleMakeModelClassViewModel);
        }

        // DELETE: api/VehicleMakeModelClassViewModels/5
        [ResponseType(typeof(VehicleMakeModelClassViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            VehicleMakeModelClassViewModel vehicleMakeModelClassViewModel = await db.VehicleMakeModelClassViewModels.FindAsync(id);
            if (vehicleMakeModelClassViewModel == null)
            {
                return NotFound();
            }

            db.VehicleMakeModelClassViewModels.Remove(vehicleMakeModelClassViewModel);
            await db.SaveChangesAsync();

            return Ok(vehicleMakeModelClassViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VehicleMakeModelClassViewModelExists(VehicleMakeModelClassViewModel vehicleMakeModelClassViewModel)
        {
            return db.VehicleMakeModelClassViewModels.Count(e => e.VehicleMakeModelClassId == vehicleMakeModelClassViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}