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
        private readonly string _connectionString;
        private readonly ConnectionStringProperty _connectionStringProperty;
        private readonly ScoringEngineEntities _db;
        private readonly ScoreManager _scoreManager;



        public ClassCodeAdjController()
        {
            _connectionStringProperty = new ConnectionStringProperty();
            // connectionString = connectionStringProperty.GetConnection(ConnectionStringTypeEnum.ScoringEngine);
            //   db = new ScoringEngineEntities(connectionString);
            // scoreManager = new ScoreManager(db);
        }


        public IQueryable<ClassCodeAdjViewModel> Get()
        {
            return _scoreManager.ClassCodeAdjViewModels;
        }

        // GET: api/ClassCodeAdjViewModels/5
        [ResponseType(typeof(ClassCodeAdjViewModel))]

        // PUT: api/ClassCodeAdjViewModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Put(ClassCodeAdjViewModel classCodeAdjViewModel)
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
                if (!ClassCodeAdjViewModelExists(classCodeAdjViewModel))
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
        public async Task<IHttpActionResult> Post(ClassCodeAdjViewModel classCodeAdjViewModel)
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
                if (!ClassCodeAdjViewModelExists(classCodeAdjViewModel))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = classCodeAdjViewModel.VehicleMakeModelClassId }, classCodeAdjViewModel);
        }

        // DELETE: api/ClassCodeAdjViewModels/5
        [ResponseType(typeof(ClassCodeAdjViewModel))]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //ClassCodeAdjViewModel ClassCodeAdjViewModel = await scoreManager.ClassCodeAdjViewModels.FindAsync(id);//
            ClassCodeAdjViewModel classCodeAdjViewModel = new ClassCodeAdjViewModel();
            if (classCodeAdjViewModel == null)
            {
                return NotFound();
            }

            //scoreManager.ClassCodeAdjViewModels.Remove(ClassCodeAdjViewModel);
            //await scoreManager.SaveChangesAsync();

            return Ok(classCodeAdjViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassCodeAdjViewModelExists(ClassCodeAdjViewModel classCodeAdjViewModel)
        {
            //hardcoded
            return false;
            //  return scoreManager.ClassCodeAdjViewModels.Count(e => e.VehicleMakeModelClassId == ClassCodeAdjViewModel.VehicleMakeModelClassId) > 0;
        }
    }
}

