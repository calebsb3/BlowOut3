using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlowOut.DAL;
using BlowOut.Models;

namespace BlowOut.Controllers
{
    public class CustomersController : Controller
    {
        private BlowOutContext db = new BlowOutContext();

        // GET: Customers
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        
        // GET: Customers/Create
        public ActionResult Create(int id)
        {
            ViewBag.id = id;
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "iCustomerID,sCustFirstName,sCustLastName,sCustAddress,sCustState,sCustCity,iCustZip,cCustPhone,cCustEmail")] Customer customer, int id)
        {
            if (ModelState.IsValid)
            {
                //First we need to create a new Instrument object to point to the instrument we clicked on in the InstrumentsController.
                Instrument instrument = db.Instruments.Find(id);

                //then we assign our instrument's customerID to the customer's ID we just created.
                instrument.iCustomerID = customer.iCustomerID;

                //Now we add the customer to our database
                db.Customers.Add(customer);
                //db.Entry(Instrument).State = EntityState.Modified;
                db.SaveChanges();

                //Go to our summary action.
                return RedirectToAction("Summary", new { CustomerID = customer.iCustomerID, InstrumentID = instrument.iInstrumentID });
            }

            return View(customer);
        }

        public ActionResult Summary(int CustomerID, int InstrumentID)
        {
            Customer customer = db.Customers.Find(CustomerID);
            Instrument instrument = db.Instruments.Find(InstrumentID);

            ViewBag.customer = customer;
            ViewBag.instrument = instrument;

            return View();

        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "iCustomerID,sCustFirstName,sCustLastName,sCustAddress,sCustState,sCustCity,iCustZip")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
