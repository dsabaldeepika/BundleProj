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
    public class ExcessMileageController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public ExcessMileageController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<ExcessMileageViewModel> GetExcessMileageViewModels()
        {
            return scoreManager.ExcessMileageViewModels;
        }

        // GET: api/ExcessMileageViewModels/5
        [ResponseType(typeof(ExcessMileageViewModel))]

        // PUT: api/ExcessMileageViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutExcessMileageViewModel(ExcessMileageViewModel ExcessMileageViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(ExcessMileageViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExcessMileageViewModelExists(ExcessMileageViewModel))
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

        // POST: api/ExcessMileageViewModels
        [ResponseType(typeof(ExcessMileageViewModel))]
        public async Task<IHttpActionResult> PostExcessMileageViewModel(ExcessMileageViewModel ExcessMileageViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.ExcessMileageViewModels.Add(ExcessMileageViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!ExcessMileageViewModelExists(ExcessMileageViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = ExcessMileageViewModel.VehicleMakeModelClassId }, ExcessMileageViewModel);
        }

        // DELETE: api/ExcessMileageViewModels/5
        [ResponseType(typeof(ExcessMileageViewModel))]
        public async Task<IHttpActionResult> DeleteExcessMileageViewModel(int id)
        {
            //ExcessMileageViewModel ExcessMileageViewModel = await scoreManager.ExcessMileageViewModels.FindAsync(id);//
            ExcessMileageViewModel ExcessMileageViewModel = new ExcessMileageViewModel();
            if (ExcessMileageViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.ExcessMileageViewModels.Remove(ExcessMileageViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(ExcessMileageViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExcessMileageViewModelExists(ExcessMileageViewModel ExcessMileageViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.ExcessMileageViewModels.Count(e => e.VehicleMakeModelClassId == ExcessMileageViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

