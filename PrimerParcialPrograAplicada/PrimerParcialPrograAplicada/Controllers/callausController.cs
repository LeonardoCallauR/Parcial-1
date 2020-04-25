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
using PrimerParcialPrograAplicada.Models;

namespace PrimerParcialPrograAplicada.Controllers
{
    public class callausController : ApiController
    {
        private DataContext db = new DataContext();
        [Authorize]
        // GET: api/callaus
        public IQueryable<callau> Getcallaus()
        {
            return db.callaus;
        }
        [Authorize]
        // GET: api/callaus/5
        [ResponseType(typeof(callau))]
        public IHttpActionResult Getcallau(int id)
        {
            callau callau = db.callaus.Find(id);
            if (callau == null)
            {
                return NotFound();
            }

            return Ok(callau);
        }
        [Authorize]
        // PUT: api/callaus/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putcallau(int id, callau callau)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != callau.CallauID)
            {
                return BadRequest();
            }

            db.Entry(callau).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!callauExists(id))
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
        [Authorize]
        // POST: api/callaus
        [ResponseType(typeof(callau))]
        public IHttpActionResult Postcallau(callau callau)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.callaus.Add(callau);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = callau.CallauID }, callau);
        }
        [Authorize]
        // DELETE: api/callaus/5
        [ResponseType(typeof(callau))]
        public IHttpActionResult Deletecallau(int id)
        {
            callau callau = db.callaus.Find(id);
            if (callau == null)
            {
                return NotFound();
            }

            db.callaus.Remove(callau);
            db.SaveChanges();

            return Ok(callau);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool callauExists(int id)
        {
            return db.callaus.Count(e => e.CallauID == id) > 0;
        }
    }
}