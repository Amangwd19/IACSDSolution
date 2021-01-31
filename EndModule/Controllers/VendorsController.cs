using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BLL;

namespace EndModule.Controllers
{
    public class VendorsController : Controller
    {
        // GET: Vendors
        public ActionResult Index()
        {
            List<string> vendors = new List<string>();
            vendors.Add("gerbera");
            vendors.Add("gerbera");
            vendors.Add("gerbera");
            vendors.Add("gerbe");
            this.ViewData["vendors"] = vendors;


            // List<Product> PP = new List<Product>();


            //  flowers = BuisnessManager.GetAllProducts();
            //  this.ViewData["flowers"] = flowers;

            List<Vendor> allVendors = BusinessManager.GetAllVendors();
            this.ViewData["vendors"] = allVendors;
            return View();
        }
        public ActionResult Details(int id)
        {
                 Vendor theVendor = BusinessManager.GetVendor(id);
                return View(theVendor);
            
        }


        public ActionResult InsertV()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertV(int id, string VName, string EmailId,
                                  string Address)
        {
            Vendor newVendor = new Vendor
            {
                ID = id,
                VName = VName,
                EmailId = EmailId,
                Address = Address,
                //Quantity = quantity,
               // ImageUrl = imageurl
            };

            bool status = BusinessManager.InsertV(newVendor);
            if (status)
            {
                this.RedirectToAction("index", "vendors");
            }
            return View();
        }


        public ActionResult UpdateV()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateV(Vendor existingVendor)
        {
            return View();
        }
    }
}