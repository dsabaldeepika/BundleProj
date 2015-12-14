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
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public ExcessMileageController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<ExcessMileageViewModel> Get()
        {
            return _scoreManager.ExcessMileageViewModels;
        }

        // GET: api/ExcessMileageViewModels/5
        [ResponseType(typeof(ExcessMileageViewModel))]

        // PUT: api/ExcessMileageViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(ExcessMileageViewModel excessMileageViewModel)
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
                if (!ExcessMileageViewModelExists(excessMileageViewModel))
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
        public async Task<IHttpActionResult> Post(ExcessMileageViewModel excessMileageViewModel)
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
                if (!ExcessMileageViewModelExists(excessMileageViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = excessMileageViewModel.VehicleMakeModelClassId }, excessMileageViewModel);
        }

        // DELETE: api/ExcessMileageViewModels/5
        [ResponseType(typeof(ExcessMileageViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //ExcessMileageViewModel ExcessMileageViewModel = await scoreManager.ExcessMileageViewModels.FindAsync(id);//
            ExcessMileageViewModel excessMileageViewModel = new ExcessMileageViewModel();
            if (excessMileageViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.ExcessMileageViewModels.Remove(ExcessMileageViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(excessMileageViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExcessMileageViewModelExists(ExcessMileageViewModel excessMileageViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.ExcessMileageViewModels.Count(e => e.VehicleMakeModelClassId == ExcessMileageViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

