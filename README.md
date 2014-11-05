OWASPTop10Tampa
===============

This is the companion site to the OWASP Tampa talk in November 2014. All of the code examples are free to use. However, be warned that they are for learning and example only. While I took every precaution to make the examples as close to production level, this is still a demo site.

#Prerequisites 

- VS Express 2013 for Web
- IIS Express (comes with VS Express)
- SQL Express or use a SQL File

#How to Get Around

The first thing you should do is create a user. This can be any user with any e-mail address. The default MVC login scheme is not set to require any validation links to be sent.

Once you have a working user try and navigate around the site and attempt to hack into the vulnerable side and the secure side. **NOTE** The secure site only uses SSL. You must follow the steps in the next section to get it working locally.

To move back and forth around the site you will click on the title of the navigation bar. So, for example, if you're in the Vulnerable Site poking around and you want to get to the secure site, you just need to click on the "Vulnerable Site" link in the upper left hand corner which will take you to the home page. You would do the same thing for the Secure Site.

You can also just replace the first part of the route URL. When changing from Vulnerable to Secure it will require SSL.

http://localhost:1566/vuln/A3
becomes
http://localhost:1566/sec/A3

#To Build / First Time

The site is fully functional and code complete. You should be able to compile it straight away. If you experience issues I recommend updating NuGet to be certain you have the proper supporting packages.

##First Build
For your first build you will need to make sure you have a database configured and specified in the web.config. Change your string to point to your proper SQL server and make sure that the user running the website has permissions to access the database.

SQLExpress
```
<add name="DefaultConnection" connectionString="Data Source=localhost\SQLEXP2014;Initial Catalog=OWASPTop10;Integrated Security=True" providerName="System.Data.SqlClient" />
```
LocalDB file
```
<add name="DefaultConnection" 
   connectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\OWASP.mdf;Integrated Security=True" 
   providerName="System.Data.SqlClient" 
/> 
```
Once you're connection string is squared away you will need to run the following commands in the NuGet Package Manager Console. If you get any messages stating that there are no changes that is okay. These commands will completely set up your database.

```
PM> Enable-Migrations
PM> Update-Database
```
That's it! You should be able to hit F5 or deploy to IIS.

#Troubleshooting

##Issues with SQL
If you're using the LocalDB, you should try deleting and recreating the SQL database file. Then, once it's created run the `Update-Database` command in the Package Manager Console.

##No SSL for IIS Express
Yep. If you use IIS Express, this will happen. Here is an article on how to enable SSL for IIS Express.
[http://www.hanselman.com/blog/WorkingWithSSLAtDevelopmentTimeIsEasierWithIISExpress.aspx]
##Random Exceptions
Not sure. Feel free to leave a comment or pull request with the stack trace and I will see what I can do.
