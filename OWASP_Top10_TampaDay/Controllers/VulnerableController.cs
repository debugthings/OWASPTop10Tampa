using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OWASP_Top10_TampaDay.Controllers
{
    [Authorize]
    public class VulnerableController : Controller
    {
        // GET: Vulnerable
        public ActionResult Index()
        {
            var cookie = new HttpCookie("SuperSecret");
            cookie.Value = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("Some really secure personal information."));
            Response.Cookies.Add(cookie);
            return View();
        }

        // GET: Vulnerable

        public ActionResult Admin()
        {
            return View("OWASP/Admin");
        }

        [HttpGet]
        public ActionResult A1()
        {
            if (HttpContext.Request.QueryString.AllKeys.Contains("searchTerm"))
            {
                string rawTerm = HttpContext.Request.QueryString["searchTerm"];
                using (var db = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.
    ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    // This can be broken with x' UNION ALL SELECT Email, PhoneNumber FROM AspNetUsers --
                    using (var cmd = new System.Data.SqlClient.SqlCommand(string.Format("SELECT Title, Abstract FROM Items WHERE Title LIKE '%{0}%' OR Abstract LIKE '%{0}%'", rawTerm), db))
                    {
                        db.Open();
                        System.Data.DataTable dt = new System.Data.DataTable();
                        System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                        da.Fill(dt);
                        ViewBag.SearchResults = dt;

                    }
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
        [ValidateInput(false)]
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
                return View("OWASP/A3", new List<Models.Items>());
            }
        }

        public ActionResult A4(string id)
        {
            ViewBag.ItemRequested = id;
            return View("OWASP/A4");
        }

        public ActionResult A6()
        {
            if (!HttpContext.Request.Cookies.AllKeys.Contains("SecureBankInfo"))
            {
                HttpContext.Response.AppendCookie(new HttpCookie("SecureBankInfo")
                {
                    Value = "RTNUM|0123456789"
                });
                HttpContext.Response.AppendCookie(new HttpCookie("UserToken")
                {
                    Value = "TOK-987654-GRANT-ADMIN"
                });
            }
            return View("OWASP/A6");
        }

        public ActionResult A7()
        {
            return View("OWASP/A7");
        }
    }
}