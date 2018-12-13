using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiEFModel;


namespace WebApiEFProviding.Controllers
{
    /// <summary>
    /// Class BRANDController is a implementation to bring live API BRAND
    /// Now is offering all classical methods: GET, PUT, POST, DELETE
    /// Creation: Gildasio Cardoso
    /// </summary>
    public class BRANDController : ApiController
    {
        // consuming Entity Framework Classe from another project
        private PortfolioModel db = new PortfolioModel();

        // GET: api/BRAND
        public IQueryable<BRAND> GetBRAND()
        {
            return db.BRAND.OrderBy(o=>new { o.SUPPLIER.DSC_SUPPLIER, o.DSC_BRAND });
        }

        // GET: api/BRAND/5
        [ResponseType(typeof(BRAND))]
        public IHttpActionResult GetBRAND(int id)
        {
            BRAND bRAND = db.BRAND.Find(id);
            if (bRAND == null)
            {
                return NotFound();
            }

            return Ok(bRAND);
        }

        // PUT: api/BRAND/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBRAND(int id, BRAND bRAND)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bRAND.ID_BRAND)
            {
                return BadRequest();
            }

            db.Entry(bRAND).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BRANDExists(id))
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

        // POST: api/BRAND
        [ResponseType(typeof(BRAND))]
        public IHttpActionResult PostBRAND(BRAND bRAND)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BRAND.Add(bRAND);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bRAND.ID_BRAND }, bRAND);
        }

        // DELETE: api/BRAND/5
        [ResponseType(typeof(BRAND))]
        public IHttpActionResult DeleteBRAND(int id)
        {
            BRAND bRAND = db.BRAND.Find(id);
            if (bRAND == null)
            {
                return NotFound();
            }

            db.BRAND.Remove(bRAND);
            db.SaveChanges();

            return Ok(bRAND);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BRANDExists(int id)
        {
            return db.BRAND.Count(e => e.ID_BRAND == id) > 0;
        }
    }
}