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
    public class FineRulesController : ApiController
    {
        private FinesDbEntities db = new FinesDbEntities();

        // GET: api/FineRules
        public IQueryable<FineRules> GetFineRules()
        {
            return db.FineRules;
        }

        // GET: api/FineRules/5
        [ResponseType(typeof(FineRules))]
        public IHttpActionResult GetFineRules(int id)
        {
            FineRules fineRules = db.FineRules.Find(id);
            if (fineRules == null)
            {
                return NotFound();
            }

            return Ok(fineRules);
        }

        // PUT: api/FineRules/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFineRules(int id, FineRules fineRules)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fineRules.Id)
            {
                return BadRequest();
            }

            db.Entry(fineRules).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FineRulesExists(id))
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

        // POST: api/FineRules
        [ResponseType(typeof(FineRules))]
        public IHttpActionResult PostFineRules(FineRules fineRules)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FineRules.Add(fineRules);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fineRules.Id }, fineRules);
        }

        // DELETE: api/FineRules/5
        [ResponseType(typeof(FineRules))]
        public IHttpActionResult DeleteFineRules(int id)
        {
            FineRules fineRules = db.FineRules.Find(id);
            if (fineRules == null)
            {
                return NotFound();
            }

            db.FineRules.Remove(fineRules);
            db.SaveChanges();

            return Ok(fineRules);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FineRulesExists(int id)
        {
            return db.FineRules.Count(e => e.Id == id) > 0;
        }
    }
}