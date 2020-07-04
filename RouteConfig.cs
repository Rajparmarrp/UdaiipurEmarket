using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Udaipur_E_Marketing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                 
               //defaults: new { controller = "User", action = "SignUp", id = UrlParameter.Optional }
               //defaults: new { controller = "User", action = "ViewAllAds", id = UrlParameter.Optional }
               defaults: new { controller = "Admin", action = "Login", id = UrlParameter.Optional }
              // defaults: new { controller = "Admin", action = "ViewCategory", id = UrlParameter.Optional }
            );
        }
    }
}
