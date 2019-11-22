using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [Route("Contact/index")]
        [Route("Contact")]
        public ActionResult Index()
        {
            ViewBag.support = "Please call Support at ";
            ViewBag.support += "<u><strong>801-555-1212</strong></u>";
            ViewBag.support += ". Thank you!";
            return View();
        }

        //These routes take precedence over the ones in the RouteConfig.cs
        //You only need one of these. Either in the Controller like this one or in the RouteConfig.cs
        //This route is attribute routing and RouteConfig.cs is conventional routing
        [Route("Contact/Email/{name:string}/{email:string}")]
        public ActionResult Email(string name, string email)
        {
            ViewBag.thanks = "Thanks " + name + ". The company will send an email to " + email;
            return View();
        }
    }
}