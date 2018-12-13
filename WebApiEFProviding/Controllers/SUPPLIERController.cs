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
    /// Class KIND_OF_PACKINGController is a implementation to bring live API KIND_OF_PACKING
    /// Now is offering all classical methods: GET, PUT, POST, DELETE
    /// Creation: Gildasio Cardoso
    /// </summary>
    public class SUPPLIERController : ApiController
    {
        private PortfolioModel db = new PortfolioModel();

        // GET: api/SUPPLIER
        public IQueryable<SUPPLIER> GetSUPPLIER()
        {
            return db.SUPPLIER.OrderBy(o=>o.DSC_SUPPLIER);
        }

        // GET: api/SUPPLIER/5
        [ResponseType(typeof(SUPPLIER))]
        public IHttpActionResult GetSUPPLIER(int id)
        {
            SUPPLIER sUPPLIER = db.SUPPLIER.Find(id);
            if (sUPPLIER == null)
            {
                return NotFound();
            }
            return Ok(sUPPLIER);
        }

        // PUT: api/SUPPLIER/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSUPPLIER(int id, SUPPLIER sUPPLIER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sUPPLIER.ID_SUPPLIER)
            {
                return BadRequest();
            }

            db.Entry(sUPPLIER).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SUPPLIERExists(id))
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

        // POST: api/SUPPLIER
        [ResponseType(typeof(SUPPLIER))]
        public IHttpActionResult PostSUPPLIER(SUPPLIER sUPPLIER)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SUPPLIER.Add(sUPPLIER);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sUPPLIER.ID_SUPPLIER }, sUPPLIER);
        }
        
        // DELETE: api/SUPPLIER/5
        [ResponseType(typeof(SUPPLIER))]
        public IHttpActionResult DeleteSUPPLIER(int id)
        {
            SUPPLIER sUPPLIER = db.SUPPLIER.Find(id);
            if (sUPPLIER == null)
            {
                return NotFound();
            }

            db.SUPPLIER.Remove(sUPPLIER);
            db.SaveChanges();

            return Ok(sUPPLIER);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SUPPLIERExists(int id)
        {
            return db.SUPPLIER.Count(e => e.ID_SUPPLIER == id) > 0;
        }
    }
}