using DealerPortalCRM.ViewModels;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
//using Com.CoreLane.Common.Models;
//using Com.CoreLane.ConfigDB.Models.ConnectionTools;
//using Com.CoreLane.StateFicoRange.Models;
//using DealerPortalCRM.DAServiceImpl
//using System.Collections.Generic;

namespace DealerPortalCRM.Controllers
{
    public class StateFicoRangeController : ApiController
    {
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;

        public StateFicoRangeController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.StateFicoRange);
            //   db = new StateFicoRangeEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }
        
        public IQueryable<StateFicoRangeViewModel> GetState()
        {
            return _scoreManager.StateFicoRangeViewModels;
        }

        // GET: api/StateFicoRangeViewModels/5
        [ResponseType(typeof(StateFicoRangeViewModel))]

        // PUT: api/StateFicoRangeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutState(StateFicoRangeViewModel stateFicoRangeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(StateFicoRangeViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StateFicoRangeViewModelExists(stateFicoRangeViewModel))
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

        // POST: api/StateFicoRangeViewModels
        [ResponseType(typeof(StateFicoRangeViewModel))]
        public async Task<IHttpActionResult> Post(StateFicoRangeViewModel stateFicoRangeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.StateFicoRangeViewModels.Add(StateFicoRangeViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!StateFicoRangeViewModelExists(stateFicoRangeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = stateFicoRangeViewModel.VehicleMakeModelClassId }, stateFicoRangeViewModel);
        }

        // DELETE: api/StateFicoRangeViewModels/5
        [ResponseType(typeof(StateFicoRangeViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //StateFicoRangeViewModel StateFicoRangeViewModel = await scoreManager.StateFicoRangeViewModels.FindAsync(id);//
            StateFicoRangeViewModel stateFicoRangeViewModel = new StateFicoRangeViewModel();
            if (stateFicoRangeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.StateFicoRangeViewModels.Remove(StateFicoRangeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(stateFicoRangeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StateFicoRangeViewModelExists(StateFicoRangeViewModel stateFicoRangeViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.StateFicoRangeViewModels.Count(e => e.VehicleMakeModelClassId == StateFicoRangeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

