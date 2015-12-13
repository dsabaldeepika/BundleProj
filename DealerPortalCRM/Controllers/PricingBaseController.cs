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
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public PricingBaseController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<PricingBaseViewModel> GetPricingBaseViewModels()
        {
            return scoreManager.PricingBaseViewModels;
        }

        // GET: api/PricingBaseViewModels/5
        [ResponseType(typeof(PricingBaseViewModel))]

        // PUT: api/PricingBaseViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPricingBaseViewModel(PricingBaseViewModel PricingBaseViewModel)
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
                if (!PricingBaseViewModelExists(PricingBaseViewModel))
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
        public async Task<IHttpActionResult> PostPricingBaseViewModel(PricingBaseViewModel PricingBaseViewModel)
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
                if (!PricingBaseViewModelExists(PricingBaseViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = PricingBaseViewModel.VehicleMakeModelClassId }, PricingBaseViewModel);
        }

        // DELETE: api/PricingBaseViewModels/5
        [ResponseType(typeof(PricingBaseViewModel))]
        public async Task<IHttpActionResult> DeletePricingBaseViewModel(int id)
        {
            //PricingBaseViewModel PricingBaseViewModel = await scoreManager.PricingBaseViewModels.FindAsync(id);//
            PricingBaseViewModel PricingBaseViewModel = new PricingBaseViewModel();
            if (PricingBaseViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.PricingBaseViewModels.Remove(PricingBaseViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(PricingBaseViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PricingBaseViewModelExists(PricingBaseViewModel PricingBaseViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.PricingBaseViewModels.Count(e => e.VehicleMakeModelClassId == PricingBaseViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

