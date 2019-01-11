using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_PL.Models;
using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Session;
using BL;

namespace Web_PL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            

            ViewData["wrong"] = "";
            UserBl ubl = new UserBl();
            // byte[] us;
            // byte[] pw;
            // ISession s = DefaultHttpContext.
            // try
            // {
            //     // ViewBag.name = ;
            // }
            // catch (System.Exception)
            // {

            //     throw;
            // }
                Console.WriteLine(HttpContext.Session.GetString("username")+"===================");

            if (HttpContext.Session.GetString("username") != null)
            {
                // string user = us.ToString();
                // string pass = pw.ToString();
                if (ubl.GetAUser(HttpContext.Session.GetString("username").ToString(), HttpContext.Session.GetString("password").ToString()) != null)
                {
                    // HttpContext.Session["un"] = new DistributedSessionStore();
                    // HttpContext.Session.SetString("username", model.userName);
                    // HttpContext.Session.SetString("password", model.password);
                    ViewData["wrong"] = "";
                    ViewData["Acc"] = HttpContext.Session.GetString("username").ToString();
                    return View("About");
                }
            }
            var model = new LoginModel();
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            //  HttpContext.Session;
            UserBl ubl = new UserBl();
            if (ubl.GetAUser(model.userName, model.password) != null)
            {
                // HttpContext.Session["un"] = new DistributedSessionStore();
                HttpContext.Session.SetString("username", model.userName);
                HttpContext.Session.SetString("password", model.password);
                // HttpContext.Items["username"]= model.password;
                // HttpContext.Session.SetString("un", model.userName);
                Console.WriteLine(HttpContext.Session.GetString("un"));
                ViewData["wrong"] = "";
                ViewData["Acc"] = model.userName;
                return View("About");
            }
            ViewData["wrong"] = "Invalid pasword or account!\nRe-enter password.";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
