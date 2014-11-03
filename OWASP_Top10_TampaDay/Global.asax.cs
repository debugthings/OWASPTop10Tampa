using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OWASP_Top10_TampaDay
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Adding a specific binder to override default behavior
            // This is a cleaner (and safer) way to bind Form posts.
            ModelBinders.Binders.Add(typeof(Models.Comments), new Models.CommentsModelBinder());
            
        }
    }
}
