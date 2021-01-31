using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;

namespace OnlineShoppingWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            this.ViewBag.message = "Welcome to ASP.NET MVC Application";
            DateTime today = DateTime.Now;
            //    string name = "Welcome to New World of MVC";
            this.ViewBag.today = today;
            return View();
        }

        public ActionResult AboutUs()
        {
            Person thePerson = new Person()
            {
                Owner = "Aman gawande",
                Company = "Transflower Learning pvt.ltd",
                Email = "aman@gmail.com",
                ContactNumber = "999999999",

            };
             this.ViewData["director"]= thePerson;
             return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}