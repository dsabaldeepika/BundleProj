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
    public class BuyRateController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public BuyRateController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<BuyRateViewModel> GetBuyRateViewModels()
        {
            return scoreManager.BuyRateViewModels;
        }

        // GET: api/BuyRateViewModels/5
        [ResponseType(typeof(BuyRateViewModel))]

        // PUT: api/BuyRateViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBuyRateViewModel(BuyRateViewModel BuyRateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(BuyRateViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuyRateViewModelExists(BuyRateViewModel))
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

        // POST: api/BuyRateViewModels
        [ResponseType(typeof(BuyRateViewModel))]
        public async Task<IHttpActionResult> PostBuyRateViewModel(BuyRateViewModel BuyRateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.BuyRateViewModels.Add(BuyRateViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!BuyRateViewModelExists(BuyRateViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = BuyRateViewModel.VehicleMakeModelClassId }, BuyRateViewModel);
        }

        // DELETE: api/BuyRateViewModels/5
        [ResponseType(typeof(BuyRateViewModel))]
        public async Task<IHttpActionResult> DeleteBuyRateViewModel(int id)
        {
            //BuyRateViewModel BuyRateViewModel = await scoreManager.BuyRateViewModels.FindAsync(id);//
            BuyRateViewModel BuyRateViewModel = new BuyRateViewModel();
            if (BuyRateViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.BuyRateViewModels.Remove(BuyRateViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(BuyRateViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BuyRateViewModelExists(BuyRateViewModel BuyRateViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.BuyRateViewModels.Count(e => e.VehicleMakeModelClassId == BuyRateViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

