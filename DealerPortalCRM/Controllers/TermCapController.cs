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
    public class TermCapController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;
        
        public TermCapController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<TermCapViewModel> GetTermCapViewModels()
        {
            return scoreManager.TermCapViewModels;
        }

        // GET: api/TermCapViewModels/5
        [ResponseType(typeof(TermCapViewModel))]

        // PUT: api/TermCapViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermCapViewModel(TermCapViewModel TermCapViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(TermCapViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermCapViewModelExists(TermCapViewModel))
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

        // POST: api/TermCapViewModels
        [ResponseType(typeof(TermCapViewModel))]
        public async Task<IHttpActionResult> PostTermCapViewModel(TermCapViewModel TermCapViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.TermCapViewModels.Add(TermCapViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!TermCapViewModelExists(TermCapViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = TermCapViewModel.VehicleMakeModelClassId }, TermCapViewModel);
        }

        // DELETE: api/TermCapViewModels/5
        [ResponseType(typeof(TermCapViewModel))]
        public async Task<IHttpActionResult> DeleteTermCapViewModel(int id)
        {
            //TermCapViewModel TermCapViewModel = await scoreManager.TermCapViewModels.FindAsync(id);//
            TermCapViewModel TermCapViewModel = new TermCapViewModel();
            if (TermCapViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.TermCapViewModels.Remove(TermCapViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(TermCapViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermCapViewModelExists(TermCapViewModel TermCapViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.TermCapViewModels.Count(e => e.VehicleMakeModelClassId == TermCapViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

