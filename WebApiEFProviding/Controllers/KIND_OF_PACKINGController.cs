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
    public class KIND_OF_PACKINGController : ApiController
    {
        private PortfolioModel db = new PortfolioModel();

        // GET: api/KIND_OF_PACKING
        public IQueryable<KIND_OF_PACKING> GetKIND_OF_PACKING()
        {
            return db.KIND_OF_PACKING;
        }

        // GET: api/KIND_OF_PACKING/5
        [ResponseType(typeof(KIND_OF_PACKING))]
        public IHttpActionResult GetKIND_OF_PACKING(int id)
        {
            KIND_OF_PACKING kIND_OF_PACKING = db.KIND_OF_PACKING.Find(id);
            if (kIND_OF_PACKING == null)
            {
                return NotFound();
            }

            return Ok(kIND_OF_PACKING);
        }

        // PUT: api/KIND_OF_PACKING/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKIND_OF_PACKING(int id, KIND_OF_PACKING kIND_OF_PACKING)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kIND_OF_PACKING.ID_KIND_OF_PACKING)
            {
                return BadRequest();
            }

            db.Entry(kIND_OF_PACKING).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KIND_OF_PACKINGExists(id))
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

        // POST: api/KIND_OF_PACKING
        [ResponseType(typeof(KIND_OF_PACKING))]
        public IHttpActionResult PostKIND_OF_PACKING(KIND_OF_PACKING kIND_OF_PACKING)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KIND_OF_PACKING.Add(kIND_OF_PACKING);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kIND_OF_PACKING.ID_KIND_OF_PACKING }, kIND_OF_PACKING);
        }

        // DELETE: api/KIND_OF_PACKING/5
        [ResponseType(typeof(KIND_OF_PACKING))]
        public IHttpActionResult DeleteKIND_OF_PACKING(int id)
        {
            KIND_OF_PACKING kIND_OF_PACKING = db.KIND_OF_PACKING.Find(id);
            if (kIND_OF_PACKING == null)
            {
                return NotFound();
            }

            db.KIND_OF_PACKING.Remove(kIND_OF_PACKING);
            db.SaveChanges();

            return Ok(kIND_OF_PACKING);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KIND_OF_PACKINGExists(int id)
        {
            return db.KIND_OF_PACKING.Count(e => e.ID_KIND_OF_PACKING == id) > 0;
        }
    }
}