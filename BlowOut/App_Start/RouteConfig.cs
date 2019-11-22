using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BlowOut
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //These are used first to last.
            //The .com on the end of the url is what was throwing an error without the last backslash
            //You can change it to be the 3rd parameter instead of the fourth and that should work
            routes.MapRoute(
                name: "Email",
                url: "Contact/Email/{name}/{email}",
                //url: "{controller}/{action}/{name}/{email}",
                //Can do url either way. Just remember the last backslash
                defaults: new { controller = "Contact", action = "Email" }
                );

            //This makes an object of MapRoute type
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

                
            );
        }
    }
}
