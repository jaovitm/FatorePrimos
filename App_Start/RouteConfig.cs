using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FatorePrimos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");        

            routes.MapRoute(
                name: "decompor",
                url: "decompor/{number}",
                defaults: new { controller = "Home", action = "Index" }
            );

        }
    }
}
