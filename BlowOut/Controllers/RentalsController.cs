using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.DAL;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        private BlowOutContext db = new BlowOutContext();
        public IEnumerable<Instrument> listofRentals;
        public CustInts newRental = new CustInts();
        public List<CustInts> allinfo = new List<CustInts>();

        public string instName = "";
        public int instNew = 0;
        public int instOld = 0;
        // GET: Rentals
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Detail(string sInstrumentDesc)
        {
            var instrument = new Instrument();

            //instrument = db.Instruments.FirstOrDefault(model => model.sInstrumentDesc = );

                //db.Database.SqlQuery<Instrument>(
                //    "SELECT " +
                //        "sInstrumentDesc, sImageFileName" +
                //    " FROM " +
                //        "Instrument" +
                //    " WHERE " +
                //        "sInstrumentDesc = '" + sInstrumentDesc + "' AND bInstrumentType = 0;"
                //    );

            return View(instrument);
        }

        public ActionResult listRentals()
        {

            listofRentals = db.Database.SqlQuery<Instrument>(
                "SELECT * " +
                "FROM Instrument " +
                "WHERE iCustomerID IS NOT NULL").ToList();

            foreach (var item in listofRentals)
            {
                newRental.instruments = item;
                newRental.customers = db.Customers.Find(item.iCustomerID);
                allinfo.Add(newRental);

            }

            return View(allinfo);
        }

        
            
        
    }
}