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
    public class DealerDiscountController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public DealerDiscountController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<DealerDiscountViewModel> GetDealerDiscountViewModels()
        {
            return scoreManager.DealerDiscountViewModels;
        }

        // GET: api/DealerDiscountViewModels/5
        [ResponseType(typeof(DealerDiscountViewModel))]

        // PUT: api/DealerDiscountViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDealerDiscountViewModel(DealerDiscountViewModel DealerDiscountViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(DealerDiscountViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DealerDiscountViewModelExists(DealerDiscountViewModel))
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

        // POST: api/DealerDiscountViewModels
        [ResponseType(typeof(DealerDiscountViewModel))]
        public async Task<IHttpActionResult> PostDealerDiscountViewModel(DealerDiscountViewModel DealerDiscountViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.DealerDiscountViewModels.Add(DealerDiscountViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!DealerDiscountViewModelExists(DealerDiscountViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = DealerDiscountViewModel.VehicleMakeModelClassId }, DealerDiscountViewModel);
        }

        // DELETE: api/DealerDiscountViewModels/5
        [ResponseType(typeof(DealerDiscountViewModel))]
        public async Task<IHttpActionResult> DeleteDealerDiscountViewModel(int id)
        {
            //DealerDiscountViewModel DealerDiscountViewModel = await scoreManager.DealerDiscountViewModels.FindAsync(id);//
            DealerDiscountViewModel DealerDiscountViewModel = new DealerDiscountViewModel();
            if (DealerDiscountViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.DealerDiscountViewModels.Remove(DealerDiscountViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(DealerDiscountViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DealerDiscountViewModelExists(DealerDiscountViewModel DealerDiscountViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.DealerDiscountViewModels.Count(e => e.VehicleMakeModelClassId == DealerDiscountViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

