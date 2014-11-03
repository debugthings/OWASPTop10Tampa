using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OWASP_Top10_TampaDay
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "IndexPage",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Home",
               url: "home/{action}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Vulnerable",
                url: "vuln/{action}",
                defaults: new { controller = "Vulnerable", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Secure",
                url: "sec/{action}",

                defaults: new { controller = "Secure", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "A4Normal",
              url: "sec/A4/{id}",
              defaults: new { controller = "Secure", action = "A4", id = UrlParameter.Optional },
              constraints: new { id = @"\d+"}
          );

            routes.MapRoute(
               name: "A4Sec",
               url: "sec/A4/USER/{id}",
               defaults: new { controller = "Secure", action = "A4User", id = UrlParameter.Optional },
               constraints: new { id = @"USER\d+"}
           );

            routes.MapRoute(
               name: "A4SecAdmin",
               url: "sec/A4/ADMIN/{id}",
               defaults: new { controller = "Secure", action = "A4Admin", id = UrlParameter.Optional },
               constraints: new { id = @"ADMIN\d+" }
           );

            routes.MapRoute(
               name: "A4Vuln",
               url: "vuln/A4/{id}",
               defaults: new { controller = "Vulnerable", action = "A4", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
