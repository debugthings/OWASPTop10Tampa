using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASP_Top10_TampaDay.Controllers
{
    [Authorize] // Must be logged in
    [RequireHttps] // Must use https
    [OutputCache(Duration = 0, NoStore = true)] // Do not store any pages
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View("OWASP/Admin");
        }


        [HttpGet]
        public ActionResult A1(string searchTerm)
        {
            string safeString = HttpUtility.UrlEncode(searchTerm);
            if (!string.IsNullOrEmpty(safeString))
            {
                using (var db = new Models.ApplicationDbContext())
                {
                    var items = from it in db.Items where it.Abstract.Contains(safeString) || it.Title.Contains(safeString) select it;
                    return View(items.ToList());
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult A3()
        {
            using (var db = new Models.ApplicationDbContext())
            {
                var models = from mod in db.Comments select mod;
                return View("OWASP/A3", models.ToList());
            }
        }
        [HttpPost]
        public ActionResult A3(Models.Comments comment)
        {
            using (var db = new Models.ApplicationDbContext())
            {
                var apUser = from user in db.Users where user.UserName == User.Identity.Name select user;
                comment.ApplicationUserId = apUser.Single();
                comment.CommentDate = DateTime.Now;
                db.Comments.Add(comment);
                db.SaveChanges();
                var models = from mod in db.Comments select mod;
                return View("OWASP/A3", models.ToList());
            }
        }


        /* 
         * A4 Actions for each of the sections. Normal, User and Admin. 
         * The A4 and A4User methods are not protected. However they have constraints on the routes
         * The A4Admin method is protected and requires admin
         */

        public ActionResult A4(string id)
        {
            ViewBag.ItemRequested = id;
            return View("OWASP/A4");
        }

        public ActionResult A4User(string id)
        {
            ViewBag.ItemRequested = id;
            return View("OWASP/A4");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult A4Admin(string id)
        {
            ViewBag.ItemRequested = id;
            return View("OWASP/A4");
        }

        // A6 simply sets secure cookies that cannot be used by non secure methods
        public ActionResult A6()
        {

            if (!HttpContext.Request.Cookies.AllKeys.Contains("SecureBankInfo"))
            {
                HttpContext.Response.AppendCookie(new HttpCookie("SecureBankInfo")
                {
                    Value = "RTNUM|0123456789",
                    Secure = true,
                    Shareable = false,
                    HttpOnly = true
                });
                HttpContext.Response.AppendCookie(new HttpCookie("UserToken")
                {
                    Value = "TOK-987654-GRANT-ADMIN",
                    Secure = true,
                    Shareable = false,
                    HttpOnly = true
                });
            }

            return View("OWASP/A6");
        }

        public ActionResult A7()
        {
            return View("OWASP/A7");
        }

        [Filters.ReferrerRedirect]
        public ActionResult A10(string Redirect)
        {
            
            if (!string.IsNullOrEmpty(Redirect))
            {
                if (Url.IsLocalUrl(Redirect))
                {
                    return A10Rediret(Redirect);
                }
            }

            return View("OWASP/A10");
        }

        [ValidateAntiForgeryToken]
        public ActionResult A10Rediret(string Redirect)
        {
            return new RedirectResult(Redirect);
        }
    }
}