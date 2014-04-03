using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_WebForm_WebApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapPageRoute(
                "WebForm1",
                "WebForm/WebForm1",
                "~/WebForms/WebForm1.aspx",
                true, null,
                new RouteValueDictionary { { "outgoing", new MyCustomConstaint() } }
            );

            // 第二個route
            //routes.MapPageRoute(
            //    "WebForm1",
            //    "WebForm/WebForm1",
            //    "~/WebForms/WebForm1.aspx",
            //    true, null,
            //    new RouteValueDictionary { { "outgoing", new MyCustomConstaint() } }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
