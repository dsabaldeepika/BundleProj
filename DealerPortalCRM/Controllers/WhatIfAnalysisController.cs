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
    public class WhatIfAnalysisController : ApiController
    {
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public WhatIfAnalysisController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<WhatIfAnalysisViewModel> Get()
        {
            return _scoreManager.WhatIfAnalysisViewModels;
        }

        // GET: api/WhatIfAnalysisViewModels/5
        [ResponseType(typeof(WhatIfAnalysisViewModel))]

        // PUT: api/WhatIfAnalysisViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(WhatIfAnalysisViewModel whatIfAnalysisViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(WhatIfAnalysisViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WhatIfAnalysisViewModelExists(whatIfAnalysisViewModel))
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

        // POST: api/WhatIfAnalysisViewModels
        [ResponseType(typeof(WhatIfAnalysisViewModel))]
        public async Task<IHttpActionResult> Post(WhatIfAnalysisViewModel whatIfAnalysisViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.WhatIfAnalysisViewModels.Add(WhatIfAnalysisViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!WhatIfAnalysisViewModelExists(whatIfAnalysisViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = whatIfAnalysisViewModel.VehicleMakeModelClassId }, whatIfAnalysisViewModel);
        }

        // DELETE: api/WhatIfAnalysisViewModels/5
        [ResponseType(typeof(WhatIfAnalysisViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //WhatIfAnalysisViewModel WhatIfAnalysisViewModel = await scoreManager.WhatIfAnalysisViewModels.FindAsync(id);//
            WhatIfAnalysisViewModel whatIfAnalysisViewModel = new WhatIfAnalysisViewModel();
            if (whatIfAnalysisViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.WhatIfAnalysisViewModels.Remove(WhatIfAnalysisViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(whatIfAnalysisViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WhatIfAnalysisViewModelExists(WhatIfAnalysisViewModel whatIfAnalysisViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.WhatIfAnalysisViewModels.Count(e => e.VehicleMakeModelClassId == WhatIfAnalysisViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

