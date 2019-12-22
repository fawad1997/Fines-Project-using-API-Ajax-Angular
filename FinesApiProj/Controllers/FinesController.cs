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
using FinesApiProj.Models;

namespace FinesApiProj.Controllers
{
    public class FinesController : ApiController
    {
        private FinesDbEntities db = new FinesDbEntities();

        // GET: api/Fines
        public IQueryable<Fines> GetFines()
        {
            return db.Fines;
        }

        // GET: api/Fines/5
        [ResponseType(typeof(Fines))]
        public IHttpActionResult GetFines(int id)
        {
            Fines fines = db.Fines.Find(id);
            if (fines == null)
            {
                return NotFound();
            }

            return Ok(fines);
        }

        // PUT: api/Fines/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFines(int id, Fines fines)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fines.Id)
            {
                return BadRequest();
            }

            db.Entry(fines).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinesExists(id))
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

        // POST: api/Fines
        [ResponseType(typeof(Fines))]
        public IHttpActionResult PostFines(Fines fines)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Fines.Add(fines);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fines.Id }, fines);
        }

        // DELETE: api/Fines/5
        [ResponseType(typeof(Fines))]
        public IHttpActionResult DeleteFines(int id)
        {
            Fines fines = db.Fines.Find(id);
            if (fines == null)
            {
                return NotFound();
            }

            db.Fines.Remove(fines);
            db.SaveChanges();

            return Ok(fines);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FinesExists(int id)
        {
            return db.Fines.Count(e => e.Id == id) > 0;
        }
    }
}