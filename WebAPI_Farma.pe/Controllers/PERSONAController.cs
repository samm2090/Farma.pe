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
using WebAPI_Farma.pe.Models;

namespace WebAPI_Farma.pe.Controllers
{
    public class PERSONAController : ApiController
    {
        private BD_FARMACIAEntities db = new BD_FARMACIAEntities();

        // GET: api/PERSONA
        public IQueryable<PERSONA> GetPERSONA()
        {
            return db.PERSONA;
        }

        // GET: api/PERSONA/5
        [ResponseType(typeof(PERSONA))]
        public IHttpActionResult GetPERSONA(int id)
        {
            PERSONA pERSONA = db.PERSONA.Find(id);
            if (pERSONA == null)
            {
                return NotFound();
            }

            return Ok(pERSONA);
        }

        // PUT: api/PERSONA/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPERSONA(int id, PERSONA pERSONA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pERSONA.PER_ID)
            {
                return BadRequest();
            }

            db.Entry(pERSONA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PERSONAExists(id))
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

        // POST: api/PERSONA
        [ResponseType(typeof(PERSONA))]
        public IHttpActionResult PostPERSONA(PERSONA pERSONA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PERSONA.Add(pERSONA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pERSONA.PER_ID }, pERSONA);
        }

        // DELETE: api/PERSONA/5
        [ResponseType(typeof(PERSONA))]
        public IHttpActionResult DeletePERSONA(int id)
        {
            PERSONA pERSONA = db.PERSONA.Find(id);
            if (pERSONA == null)
            {
                return NotFound();
            }

            db.PERSONA.Remove(pERSONA);
            db.SaveChanges();

            return Ok(pERSONA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PERSONAExists(int id)
        {
            return db.PERSONA.Count(e => e.PER_ID == id) > 0;
        }
    }
}