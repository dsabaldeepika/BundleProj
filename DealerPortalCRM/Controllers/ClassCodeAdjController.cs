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
    public class ClassCodeAdjController : ApiController
    {
        private readonly string connectionString;
        private readonly ConnectionStringProperty connectionStringProperty;
        private readonly ScoringEngineEntities db;
        private readonly ScoreManager scoreManager;



        public ClassCodeAdjController()
        {
            connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<ClassCodeAdjViewModel> GetClassCodeAdjViewModels()
        {
            return scoreManager.ClassCodeAdjViewModels;
        }

        // GET: api/ClassCodeAdjViewModels/5
        [ResponseType(typeof(ClassCodeAdjViewModel))]

        // PUT: api/ClassCodeAdjViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassCodeAdjViewModel(ClassCodeAdjViewModel ClassCodeAdjViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                //scoreManager.Entry(ClassCodeAdjViewModel).State = EntityState.Modified;
                // await scoreManager.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassCodeAdjViewModelExists(ClassCodeAdjViewModel))
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

        // POST: api/ClassCodeAdjViewModels
        [ResponseType(typeof(ClassCodeAdjViewModel))]
        public async Task<IHttpActionResult> PostClassCodeAdjViewModel(ClassCodeAdjViewModel ClassCodeAdjViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                //scoreManager.ClassCodeAdjViewModels.Add(ClassCodeAdjViewModel);
                //await scoreManager.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!ClassCodeAdjViewModelExists(ClassCodeAdjViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = ClassCodeAdjViewModel.VehicleMakeModelClassId }, ClassCodeAdjViewModel);
        }

        // DELETE: api/ClassCodeAdjViewModels/5
        [ResponseType(typeof(ClassCodeAdjViewModel))]
        public async Task<IHttpActionResult> DeleteClassCodeAdjViewModel(int id)
        {
            //ClassCodeAdjViewModel ClassCodeAdjViewModel = await scoreManager.ClassCodeAdjViewModels.FindAsync(id);//
            ClassCodeAdjViewModel ClassCodeAdjViewModel = new ClassCodeAdjViewModel();
            if (ClassCodeAdjViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.ClassCodeAdjViewModels.Remove(ClassCodeAdjViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(ClassCodeAdjViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassCodeAdjViewModelExists(ClassCodeAdjViewModel ClassCodeAdjViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.ClassCodeAdjViewModels.Count(e => e.VehicleMakeModelClassId == ClassCodeAdjViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

