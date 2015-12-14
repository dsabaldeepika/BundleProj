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
    public class PricingBaseController : ApiController
    {
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public PricingBaseController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<PricingBaseViewModel> Get()
        {
            return _scoreManager.PricingBaseViewModels;
        }

        // GET: api/PricingBaseViewModels/5
        [ResponseType(typeof(PricingBaseViewModel))]

        // PUT: api/PricingBaseViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(PricingBaseViewModel pricingBaseViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(PricingBaseViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PricingBaseViewModelExists(pricingBaseViewModel))
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

        // POST: api/PricingBaseViewModels
        [ResponseType(typeof(PricingBaseViewModel))]
        public async Task<IHttpActionResult> Post(PricingBaseViewModel pricingBaseViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.PricingBaseViewModels.Add(PricingBaseViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!PricingBaseViewModelExists(pricingBaseViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pricingBaseViewModel.VehicleMakeModelClassId }, pricingBaseViewModel);
        }

        // DELETE: api/PricingBaseViewModels/5
        [ResponseType(typeof(PricingBaseViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //PricingBaseViewModel PricingBaseViewModel = await scoreManager.PricingBaseViewModels.FindAsync(id);//
            PricingBaseViewModel pricingBaseViewModel = new PricingBaseViewModel();
            if (pricingBaseViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.PricingBaseViewModels.Remove(PricingBaseViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(pricingBaseViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PricingBaseViewModelExists(PricingBaseViewModel pricingBaseViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.PricingBaseViewModels.Count(e => e.VehicleMakeModelClassId == PricingBaseViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

