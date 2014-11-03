using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASP_Top10_TampaDay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpContext.Session.Add("FirstPageHit", DateTime.Now);

            // Expire these two cookies used in A6 for proper functionality
            if (HttpContext.Request.Cookies.AllKeys.Contains("SecureBankInfo"))
            {
                HttpContext.Response.Cookies["SecureBankInfo"].Expires = DateTime.Now.AddYears(-1) ;
            }

            if (HttpContext.Request.Cookies.AllKeys.Contains("UserToken"))
            {
                HttpContext.Response.Cookies["UserToken"].Expires = DateTime.Now.AddYears(-1);
            }
            
            
            return View();
        }

        public ActionResult About()
        {
          

            return View();
        }

        public ActionResult FAQ()
        {


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}