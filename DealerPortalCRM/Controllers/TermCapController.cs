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
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;
        
        public TermCapController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<TermCapViewModel> Get()
        {
            return _scoreManager.TermCapViewModels;
        }

        // GET: api/TermCapViewModels/5
        [ResponseType(typeof(TermCapViewModel))]

        // PUT: api/TermCapViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(TermCapViewModel termCapViewModel)
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
                if (!TermCapViewModelExists(termCapViewModel))
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
        public async Task<IHttpActionResult> Post(TermCapViewModel termCapViewModel)
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
                if (!TermCapViewModelExists(termCapViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = termCapViewModel.VehicleMakeModelClassId }, termCapViewModel);
        }

        // DELETE: api/TermCapViewModels/5
        [ResponseType(typeof(TermCapViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //TermCapViewModel TermCapViewModel = await scoreManager.TermCapViewModels.FindAsync(id);//
            TermCapViewModel termCapViewModel = new TermCapViewModel();
            if (termCapViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.TermCapViewModels.Remove(TermCapViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(termCapViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermCapViewModelExists(TermCapViewModel termCapViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.TermCapViewModels.Count(e => e.VehicleMakeModelClassId == TermCapViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

