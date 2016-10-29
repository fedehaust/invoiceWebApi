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
using WebApi;

namespace WebApi.Controllers
{
    public class invoiceController : ApiController
    {
        private parcial2BaseDatosEntities db = new parcial2BaseDatosEntities();

        // GET: api/invoice/1
        [ResponseType(typeof(invoice))]
        public IHttpActionResult Getinvoice(int id)
        {
            invoice invoice = db.invoice.Find(id);
            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }


        // POST: api/invoice
        [ResponseType(typeof(invoice))]
        public IHttpActionResult Postinvoice(invoice invoice)
        {
            //invoice = new WebApi.invoice();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (invoice != null)
            {
                db.invoice.Add(invoice);
                db.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = invoice.invoiceNumber }, invoice);
            }else
            {
                return CreatedAtRoute("DefaultApi", new { }, "No Invoice information");
            }
        }

        // POST: api/invoice/details
        [ResponseType(typeof(invoice_detail))]
        [Route("api/invoice/details")]
        public IHttpActionResult PostinvoiceDetail(invoice_detail invoice_detail)
        {
            //invoice_detail = new WebApi.invoice_detail();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (invoice_detail != null)
            {
                db.invoice_detail.Add(invoice_detail);
                db.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { controller = "invoice", id = invoice_detail.articleId }, invoice_detail);
            }else
            {
                return CreatedAtRoute("DefaultApi", new { controller = "invoice" }, "No Invoice detail information");
            }
        }
    }
}