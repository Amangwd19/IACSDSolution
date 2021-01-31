using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace OnlineShoppingWeb.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<string> flowers = new List<string>();
            flowers.Add("gerbera");
            flowers.Add("gerbera");
            flowers.Add("gerbera");
            flowers.Add("gerbe");
            this.ViewData["flowers"] = flowers;


            // List<Product> PP = new List<Product>();


            //  flowers = BuisnessManager.GetAllProducts();
            //  this.ViewData["flowers"] = flowers;

            List<Product> allProducts = BusinessManager.GetAllProducts();
            this.ViewData["products"] = allProducts;

            return View();
        }

        public ActionResult Details(int id)
        {
            Product theProduct = BusinessManager.GetProduct(id);
            return View(theProduct);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Product newProduct)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Product existingProduct)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }


    }
}