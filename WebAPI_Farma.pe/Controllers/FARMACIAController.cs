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
    public class FARMACIAController : ApiController
    {
        private BD_FARMACIAEntities db = new BD_FARMACIAEntities();

        // GET: api/FARMACIA
        public IQueryable<FARMACIA> GetFARMACIAs()
        {
            return db.FARMACIAs;
        }

        // GET: api/FARMACIA/5
        [ResponseType(typeof(FARMACIA))]
        public IHttpActionResult GetFARMACIA(int id)
        {
            FARMACIA fARMACIA = db.FARMACIAs.Find(id);
            if (fARMACIA == null)
            {
                return NotFound();
            }

            return Ok(fARMACIA);
        }

        // GET: api/FARMACIA/5
        [ResponseType(typeof(List<FARMACIA>))]
        public IHttpActionResult GetFARMACIASxDISTRITO(int id_dis)
        {
            if (db.USP_FARMACIAS_X_DISTRITO(id_dis) == null)
            {
                return NotFound();
            }

            return Ok(db.USP_FARMACIAS_X_DISTRITO(id_dis));
        }

        // PUT: api/FARMACIA/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFARMACIA(int id, FARMACIA fARMACIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fARMACIA.ID_FAR)
            {
                return BadRequest();
            }

            db.Entry(fARMACIA).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FARMACIAExists(id))
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

        // POST: api/FARMACIA
        [ResponseType(typeof(FARMACIA))]
        public IHttpActionResult PostFARMACIA(FARMACIA fARMACIA)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FARMACIAs.Add(fARMACIA);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fARMACIA.ID_FAR }, fARMACIA);
        }

        // DELETE: api/FARMACIA/5
        [ResponseType(typeof(FARMACIA))]
        public IHttpActionResult DeleteFARMACIA(int id)
        {
            FARMACIA fARMACIA = db.FARMACIAs.Find(id);
            if (fARMACIA == null)
            {
                return NotFound();
            }

            db.FARMACIAs.Remove(fARMACIA);
            db.SaveChanges();

            return Ok(fARMACIA);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FARMACIAExists(int id)
        {
            return db.FARMACIAs.Count(e => e.ID_FAR == id) > 0;
        }
    }
}