using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
namespace OnlineShoppingWeb.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            if(username == "ravi" && password== "seed")
            {
                return this.RedirectToAction("index", "home");
            }
            return View();
        }


        [ActionName("Register")]
        public ActionResult Register_Get()
        {
            return View();
        }


        [HttpPost]
        [ActionName("Register")]
        public ActionResult Register_Post(Customer customer)
        {
            TryValidateModel(customer);
            if(ModelState.IsValid)
            {
                return RedirectToAction("login", "accounts");
            }
            return View();
        }





      /*  public ActionResult Register()
        {
            return View();
        }

      */

     /*   [HttpPost]
        public ActionResult Register(string firstname,string lastname,int age,
                                     string email,string contactnumber, string location)
        {

          return View();
        }
     */
    }
}