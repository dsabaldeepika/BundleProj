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
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public BuyRateController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<BuyRateViewModel> Get()
        {
            return _scoreManager.BuyRateViewModels;
        }

        // GET: api/BuyRateViewModels/5
        [ResponseType(typeof(BuyRateViewModel))]

        // PUT: api/BuyRateViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(BuyRateViewModel buyRateViewModel)
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
                if (!BuyRateViewModelExists(buyRateViewModel))
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
        public async Task<IHttpActionResult> Post(BuyRateViewModel buyRateViewModel)
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
                if (!BuyRateViewModelExists(buyRateViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = buyRateViewModel.VehicleMakeModelClassId }, buyRateViewModel);
        }

        // DELETE: api/BuyRateViewModels/5
        [ResponseType(typeof(BuyRateViewModel))]
        public async Task<IHttpActionResult> DeleteBuyRateViewModel(int id)
        {
            //BuyRateViewModel BuyRateViewModel = await scoreManager.BuyRateViewModels.FindAsync(id);//
            BuyRateViewModel buyRateViewModel = new BuyRateViewModel();
            if (buyRateViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.BuyRateViewModels.Remove(BuyRateViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(buyRateViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BuyRateViewModelExists(BuyRateViewModel buyRateViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.BuyRateViewModels.Count(e => e.VehicleMakeModelClassId == BuyRateViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

