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
    public class DocFeeController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public DocFeeController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<DocFeeViewModel> GetDocFeeViewModels()
        {
            return scoreManager.DocFeeViewModels;
        }

        // GET: api/DocFeeViewModels/5
        [ResponseType(typeof(DocFeeViewModel))]

        // PUT: api/DocFeeViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDocFeeViewModel(DocFeeViewModel DocFeeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(DocFeeViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocFeeViewModelExists(DocFeeViewModel))
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

        // POST: api/DocFeeViewModels
        [ResponseType(typeof(DocFeeViewModel))]
        public async Task<IHttpActionResult> PostDocFeeViewModel(DocFeeViewModel DocFeeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.DocFeeViewModels.Add(DocFeeViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!DocFeeViewModelExists(DocFeeViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = DocFeeViewModel.VehicleMakeModelClassId }, DocFeeViewModel);
        }

        // DELETE: api/DocFeeViewModels/5
        [ResponseType(typeof(DocFeeViewModel))]
        public async Task<IHttpActionResult> DeleteDocFeeViewModel(int id)
        {
            //DocFeeViewModel DocFeeViewModel = await scoreManager.DocFeeViewModels.FindAsync(id);//
            DocFeeViewModel DocFeeViewModel = new DocFeeViewModel();
            if (DocFeeViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.DocFeeViewModels.Remove(DocFeeViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(DocFeeViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DocFeeViewModelExists(DocFeeViewModel DocFeeViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.DocFeeViewModels.Count(e => e.VehicleMakeModelClassId == DocFeeViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

