namespace OWASP_Top10_TampaDay.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using OWASP_Top10_TampaDay.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OWASP_Top10_TampaDay.Models.ApplicationDbContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OWASP_Top10_TampaDay.Models.ApplicationDbContext";
        }

        protected override void Seed(OWASP_Top10_TampaDay.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Comments.AddOrUpdate(
                 new Models.Comments { Comment = "Excellent job!", CommentDate = DateTime.Parse("11/3/2014 10:00:00") },
                 new Models.Comments { Comment = "Great talk!", CommentDate = DateTime.Parse("11/03/2014 10:01:00") },
                 new Models.Comments { Comment = "Very useful information! Ping Back: <a href=\"www.debugthings.com\">My Blog!!</a>", CommentDate = DateTime.Parse("11/3/2014  10:01:00") },
                 new Models.Comments { Comment = "<h3>SO MUCH GREAT INFORMATION</h3>", CommentDate = DateTime.Parse("11/3/2014  10:03:00") },
                 new Models.Comments { Comment = "<span style=\"color: #ff0000\">DOOOOOOOOD</span>", CommentDate = DateTime.Parse("11/3/2014  11:01:00") },
                 new Models.Comments { Comment = "<div><span style=\"color:#ff0000;\">M</span><span style=\"color:#ff1200;\">a</span><span style=\"color:#ff2400;\">n</span><span style=\"color:#ff3600;\"> </span><span style=\"color:#ff4900;\">y</span><span style=\"color:#ff5b00;\">o</span><span style=\"color:#ff6d00;\">u</span><span style=\"color:#ff7f00;\">r</span><span style=\"color:#ff8f00;\"> </span><span style=\"color:#ff9f00;\">c</span><span style=\"color:#ffaf00;\">o</span><span style=\"color:#ffbf00;\">m</span><span style=\"color:#ffcf00;\">m</span><span style=\"color:#ffdf00;\">e</span><span style=\"color:#ffef00;\">n</span><span style=\"color:#ffff00;\">t</span><span style=\"color:#dbff00;\">s</span><span style=\"color:#b6ff00;\"> </span><span style=\"color:#92ff00;\">s</span><span style=\"color:#6dff00;\">e</span><span style=\"color:#49ff00;\">c</span><span style=\"color:#24ff00;\">t</span><span style=\"color:#00ff00;\">i</span><span style=\"color:#00ff20;\">o</span><span style=\"color:#00ff40;\">n</span><span style=\"color:#00ff60;\"> </span><span style=\"color:#00ff80;\">i</span><span style=\"color:#00ff9f;\">s</span><span style=\"color:#00ffbf;\"> </span><span style=\"color:#00ffdf;\">t</span><span style=\"color:#00ffff;\">h</span><span style=\"color:#00dbff;\">e</span><span style=\"color:#00b6ff;\"> </span><span style=\"color:#0092ff;\">b</span><span style=\"color:#006dff;\">e</span><span style=\"color:#0049ff;\">s</span><span style=\"color:#0024ff;\">t</span><span style=\"color:#0000ff;\">!</span></div>", CommentDate = DateTime.Parse("11/03/2014 10:01:00") });

            context.Items.AddOrUpdate(
                new Models.Items
                {
                    Title = "How to stop injection attacks.",
                    Abstract = "The best resource for injection attacks for .NET and MVC. Written by Scott Hanselan and Phil Haack.",
                    Detail = @"Bacon ipsum dolor amet pork belly short ribs corned beef flank chuck dolor incididunt beef ribs et venison sint pork loin. Est deserunt tail ground round, frankfurter tempor officia. Velit nisi turducken ribeye occaecat mollit pancetta. Culpa veniam ball tip shank prosciutto aliqua short loin nisi incididunt ribeye doner excepteur. Nisi pig dolor, dolore landjaeger cupidatat porchetta drumstick. Velit sunt boudin salami, irure id reprehenderit consequat chuck. Tenderloin in do porchetta eu magna sed short ribs tail.

Culpa consectetur sausage in eu corned beef bacon dolore veniam kevin et pariatur esse strip steak landjaeger. Andouille shoulder dolore ut pastrami. Brisket tri-tip pariatur fatback sausage kielbasa nulla landjaeger turducken officia. Ea laboris aliqua pork chop et. Aute minim sirloin labore tongue ut.

Beef ribs pork velit, dolore exercitation frankfurter lorem voluptate meatloaf cillum bacon do ground round. Short loin salami pariatur fugiat ham hock in lorem meatloaf consequat pork ea shoulder. Cupidatat dolore id, quis tail andouille turducken exercitation. Doner jowl dolore, fugiat venison id laborum lorem reprehenderit pork loin voluptate frankfurter ea velit ut. Beef ribs kevin proident in, ex meatloaf ham hock ullamco ea eiusmod turkey pork belly. Minim pariatur prosciutto, labore aliqua jerky venison proident andouille kielbasa consequat dolor."
                },
                 new Models.Items
                 {
                     Title = "XSS and you",
                     Abstract = "XSS attacks are more prevalent than you think. This article explores how <span style=\"color: #ff0000\">XSS and MVC</span> affect you.",
                     Detail = @"Bacon ipsum dolor amet pork belly short ribs corned beef flank chuck dolor incididunt beef ribs et venison sint pork loin. Est deserunt tail ground round, frankfurter tempor officia. Velit nisi turducken ribeye occaecat mollit pancetta. Culpa veniam ball tip shank prosciutto aliqua short loin nisi incididunt ribeye doner excepteur. Nisi pig dolor, dolore landjaeger cupidatat porchetta drumstick. Velit sunt boudin salami, irure id reprehenderit consequat chuck. Tenderloin in do porchetta eu magna sed short ribs tail.

Culpa consectetur sausage in eu corned beef bacon dolore veniam kevin et pariatur esse strip steak landjaeger. Andouille shoulder dolore ut pastrami. Brisket tri-tip pariatur fatback sausage kielbasa nulla landjaeger turducken officia. Ea laboris aliqua pork chop et. Aute minim sirloin labore tongue ut.

Beef ribs pork velit, dolore exercitation frankfurter lorem voluptate meatloaf cillum bacon do ground round. Short loin salami pariatur fugiat ham hock in lorem meatloaf consequat pork ea shoulder. Cupidatat dolore id, quis tail andouille turducken exercitation. Doner jowl dolore, fugiat venison id laborum lorem reprehenderit pork loin voluptate frankfurter ea velit ut. Beef ribs kevin proident in, ex meatloaf ham hock ullamco ea eiusmod turkey pork belly. Minim pariatur prosciutto, labore aliqua jerky venison proident andouille kielbasa consequat dolor."
                 },
                 new Models.Items
                 {
                     Title = "Learn MVC!",
                     Abstract = "The <b>only</b> MVC resource you will ever need. Learn all about Models, Views and Controllers.",
                     Detail = @"Bacon ipsum dolor amet pork belly short ribs corned beef flank chuck dolor incididunt beef ribs et venison sint pork loin. Est deserunt tail ground round, frankfurter tempor officia. Velit nisi turducken ribeye occaecat mollit pancetta. Culpa veniam ball tip shank prosciutto aliqua short loin nisi incididunt ribeye doner excepteur. Nisi pig dolor, dolore landjaeger cupidatat porchetta drumstick. Velit sunt boudin salami, irure id reprehenderit consequat chuck. Tenderloin in do porchetta eu magna sed short ribs tail.

Culpa consectetur sausage in eu corned beef bacon dolore veniam kevin et pariatur esse strip steak landjaeger. Andouille shoulder dolore ut pastrami. Brisket tri-tip pariatur fatback sausage kielbasa nulla landjaeger turducken officia. Ea laboris aliqua pork chop et. Aute minim sirloin labore tongue ut.

Beef ribs pork velit, dolore exercitation frankfurter lorem voluptate meatloaf cillum bacon do ground round. Short loin salami pariatur fugiat ham hock in lorem meatloaf consequat pork ea shoulder. Cupidatat dolore id, quis tail andouille turducken exercitation. Doner jowl dolore, fugiat venison id laborum lorem reprehenderit pork loin voluptate frankfurter ea velit ut. Beef ribs kevin proident in, ex meatloaf ham hock ullamco ea eiusmod turkey pork belly. Minim pariatur prosciutto, labore aliqua jerky venison proident andouille kielbasa consequat dolor."
                 },
                 new Models.Items
                 {
                     Title = "Publish on GitHub",
                     Abstract = "A primer on how you can publish your website to GitHub and use <a href =\"http://azure.microsoft.com\">Azure</a> to host in the cloud.",
                     Detail = @"Bacon ipsum dolor amet pork belly short ribs corned beef flank chuck dolor incididunt beef ribs et venison sint pork loin. Est deserunt tail ground round, frankfurter tempor officia. Velit nisi turducken ribeye occaecat mollit pancetta. Culpa veniam ball tip shank prosciutto aliqua short loin nisi incididunt ribeye doner excepteur. Nisi pig dolor, dolore landjaeger cupidatat porchetta drumstick. Velit sunt boudin salami, irure id reprehenderit consequat chuck. Tenderloin in do porchetta eu magna sed short ribs tail.

Culpa consectetur sausage in eu corned beef bacon dolore veniam kevin et pariatur esse strip steak landjaeger. Andouille shoulder dolore ut pastrami. Brisket tri-tip pariatur fatback sausage kielbasa nulla landjaeger turducken officia. Ea laboris aliqua pork chop et. Aute minim sirloin labore tongue ut.

Beef ribs pork velit, dolore exercitation frankfurter lorem voluptate meatloaf cillum bacon do ground round. Short loin salami pariatur fugiat ham hock in lorem meatloaf consequat pork ea shoulder. Cupidatat dolore id, quis tail andouille turducken exercitation. Doner jowl dolore, fugiat venison id laborum lorem reprehenderit pork loin voluptate frankfurter ea velit ut. Beef ribs kevin proident in, ex meatloaf ham hock ullamco ea eiusmod turkey pork belly. Minim pariatur prosciutto, labore aliqua jerky venison proident andouille kielbasa consequat dolor."
                 },
                 new Models.Items
                 {
                     Title = "SQL Injection Basics",
                     Abstract = "A great listing of common SQL injections that will uncover <i>90%</i> of a databases information.",
                     Detail = @"Bacon ipsum dolor amet pork belly short ribs corned beef flank chuck dolor incididunt beef ribs et venison sint pork loin. Est deserunt tail ground round, frankfurter tempor officia. Velit nisi turducken ribeye occaecat mollit pancetta. Culpa veniam ball tip shank prosciutto aliqua short loin nisi incididunt ribeye doner excepteur. Nisi pig dolor, dolore landjaeger cupidatat porchetta drumstick. Velit sunt boudin salami, irure id reprehenderit consequat chuck. Tenderloin in do porchetta eu magna sed short ribs tail.

Culpa consectetur sausage in eu corned beef bacon dolore veniam kevin et pariatur esse strip steak landjaeger. Andouille shoulder dolore ut pastrami. Brisket tri-tip pariatur fatback sausage kielbasa nulla landjaeger turducken officia. Ea laboris aliqua pork chop et. Aute minim sirloin labore tongue ut.

Beef ribs pork velit, dolore exercitation frankfurter lorem voluptate meatloaf cillum bacon do ground round. Short loin salami pariatur fugiat ham hock in lorem meatloaf consequat pork ea shoulder. Cupidatat dolore id, quis tail andouille turducken exercitation. Doner jowl dolore, fugiat venison id laborum lorem reprehenderit pork loin voluptate frankfurter ea velit ut. Beef ribs kevin proident in, ex meatloaf ham hock ullamco ea eiusmod turkey pork belly. Minim pariatur prosciutto, labore aliqua jerky venison proident andouille kielbasa consequat dolor."
                 },
                 new Models.Items
                 {
                     Title = "XSS Injection Basics",
                     Abstract = "A great listing of common XSS injections that will break even the most seasoned XSS engine.",
                     Detail = @"Bacon ipsum dolor amet pork belly short ribs corned beef flank chuck dolor incididunt beef ribs et venison sint pork loin. Est deserunt tail ground round, frankfurter tempor officia. Velit nisi turducken ribeye occaecat mollit pancetta. Culpa veniam ball tip shank prosciutto aliqua short loin nisi incididunt ribeye doner excepteur. Nisi pig dolor, dolore landjaeger cupidatat porchetta drumstick. Velit sunt boudin salami, irure id reprehenderit consequat chuck. Tenderloin in do porchetta eu magna sed short ribs tail.

Culpa consectetur sausage in eu corned beef bacon dolore veniam kevin et pariatur esse strip steak landjaeger. Andouille shoulder dolore ut pastrami. Brisket tri-tip pariatur fatback sausage kielbasa nulla landjaeger turducken officia. Ea laboris aliqua pork chop et. Aute minim sirloin labore tongue ut.

Beef ribs pork velit, dolore exercitation frankfurter lorem voluptate meatloaf cillum bacon do ground round. Short loin salami pariatur fugiat ham hock in lorem meatloaf consequat pork ea shoulder. Cupidatat dolore id, quis tail andouille turducken exercitation. Doner jowl dolore, fugiat venison id laborum lorem reprehenderit pork loin voluptate frankfurter ea velit ut. Beef ribs kevin proident in, ex meatloaf ham hock ullamco ea eiusmod turkey pork belly. Minim pariatur prosciutto, labore aliqua jerky venison proident andouille kielbasa consequat dolor."
                 }
                );

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));


            //Create Role Admin if it does not exist
            if (!RoleManager.RoleExists("Admin"))
            {
                var roleresult = RoleManager.Create(new IdentityRole("Admin"));
            }
            //Create Role Admin if it does not exist
            if (!RoleManager.RoleExists("User"))
            {
                var roleresult = RoleManager.Create(new IdentityRole("User"));
            }

            CreateAdminUser("Admin", UserManager);
            CreateUser("JamesD", UserManager);
            CreateUser("RichR", UserManager);
            CreateUser("SteveR", UserManager);
            CreateUser("GaryB", UserManager);
            CreateUser("JustinM", UserManager);
            CreateUser("BretM", UserManager);
            CreateUser("User1", UserManager);
            CreateUser("User2", UserManager);
            CreateUser("User3", UserManager);
            CreateUser("User4", UserManager);
            CreateUser("User5", UserManager);
            CreateUser("User6", UserManager);
            CreateUser("User7", UserManager);
            CreateUser("User8", UserManager);
            CreateUser("User9", UserManager);
            context.SaveChanges();
        }

        private void CreateAdminUser(string UserName, UserManager<ApplicationUser> UserManager)
        {
            //Create User=Admin 
            var userAdmin = new ApplicationUser()
            {
                UserName = UserName,
                Email = string.Format("{0}@owasp.org", UserName),
                PhoneNumber = "(800) 111-2222"
            };
            if (UserManager.FindByEmail(userAdmin.Email) == null)
            {
                var adminresult = UserManager.Create(userAdmin, "!Top10Top10!");
                //Add User Admin to Role Admin
                if (adminresult.Succeeded)
                {
                    var result = UserManager.AddToRole(userAdmin.Id, "Admin");
                }
            }
            
        }

        private void CreateUser(string UserName, UserManager<ApplicationUser> UserManager)
        {
            //Create User=Admin 
            var userAdmin = new ApplicationUser()
            {
                UserName = UserName,
                Email = string.Format("{0}@owasp.org", UserName),
                PhoneNumber = "(800) 111-2222"
            };
            var adminresult = UserManager.Create(userAdmin, "!Top10Top10!");
            //Add User Admin to Role Admin
            if (adminresult.Succeeded)
            {
                var result = UserManager.AddToRole(userAdmin.Id, "User");
            }
        }

    }
}
