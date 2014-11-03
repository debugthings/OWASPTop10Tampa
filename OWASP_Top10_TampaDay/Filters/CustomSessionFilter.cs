using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASP_Top10_TampaDay.Filters
{
    public class CustomSessionAttrbute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            HttpContext.Current.Session["IsNewCookie"] = true;
        }
    }
}