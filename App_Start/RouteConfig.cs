using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FinalProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
                name: "Default",
                url: "auth/{action}/{id}",      
                defaults: new { controller = "Auth", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Logins",
                url: "logins",
                defaults: new { controller = "Logins", action = "Index", id = UrlParameter.Optional }
                );

        }
    }
}
