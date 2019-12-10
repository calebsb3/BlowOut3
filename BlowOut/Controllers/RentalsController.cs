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
        public List<Instrument> listofRentals = new List<Instrument>();
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

            listofRentals = db.Instruments.ToList();

            foreach (var item in listofRentals)
            {
                //allinfo.Add(db.Database.SqlQuery( ))
                //create list object of type custints
                //sql query to return each rental and its info
                //set it to the list
            }

            return View();
        }

        //public ActionResult TrumpetDet()
        //{
        //    return View();
        //}

        //public ActionResult TromboneDet()
        //{
        //    return View();
        //}

        //public ActionResult SaxDet()
        //{
        //    return View();
        //}

        //public ActionResult TubaDet()
        //{
        //    return View();
        //}

        //public ActionResult FluteDet()
        //{
        //    return View();
        //}

        //public ActionResult ClarDet()
        //{
        //    return View();
        //}

        

        //public ActionResult NewUsedPrice(string stype, string instrumentID)
        //{
        //    if (instrumentID == "Trumpet")
        //    {
        //        instName = "Trumpet";
        //        instNew = 55;
        //        instOld = 25;
        //        if (stype == "New")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instNew + " dollars a month.";
        //        }
        //        else if (stype == "Used")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instOld + " dollars a month.";
        //        }
        //        return View();
                
        //    }
        //    else if (instrumentID == "Trombone")
        //    {
        //        instName = "Trombone";
        //        instNew = 60;
        //        instOld = 35;
        //        if (stype == "New")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instNew + " dollars a month.";
        //        }
        //        else if (stype == "Used")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instOld + " dollars a month.";
        //        }
        //        return View();

        //    }
        //    else if (instrumentID == "Tuba")
        //    {
        //        instName = "Tuba";
        //        instNew = 70;
        //        instOld = 50;
        //        if (stype == "New")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instNew + " dollars a month.";
        //        }
        //        else if (stype == "Used")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instOld + " dollars a month.";
        //        }
        //        return View();
        //    }
        //    else if (instrumentID == "Flute")
        //    {
        //        instName = "Flute";
        //        instNew = 40;
        //        instOld = 25;
        //        if (stype == "New")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instNew + " dollars a month.";
        //        }
        //        else if (stype == "Used")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instOld + " dollars a month.";
        //        }
                
        //        return View();
                
        //    }
        //    else if (instrumentID == "Clarinet")
        //    {
        //        instName = "Clarinet";
        //        instNew = 35;
        //        instOld = 27;
        //        if (stype == "New")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instNew + " dollars a month.";
        //        }
        //        else if (stype == "Used")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instOld + " dollars a month.";
        //        }
                
        //        return View();
                
        //    }
        //    else if (instrumentID == "Saxophone")
        //    {
        //        instName = "Saxophone";
        //        instNew = 42;
        //        instOld = 30;
        //        if (stype == "New")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instNew + " dollars a month.";
        //        }
        //        else if (stype == "Used")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instOld + " dollars a month.";
        //        }
                
        //        return View();
                
        //    }
        //    else
        //    {
        //        instName = "";
        //        instNew = 0;
        //        instOld = 0;
        //        if (stype == "New")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instNew + " dollars a month.";
        //        }
        //        else if (stype == "Used")
        //        {
        //            ViewBag.instrumentprice = "The " + instName + " will cost $" + instOld + " dollars a month.";
        //        }
        //        return View();
        //    }
            
        }
    }
}