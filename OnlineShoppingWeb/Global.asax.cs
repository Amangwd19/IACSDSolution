using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BOL;

namespace OnlineShoppingWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Session_Start()
        {
            Cart theCart = new Cart();
            this.Session.Add("shoppingcart", theCart);
        }
        public void Session_End()
        {
            Cart theExistingCart = this.Session["shoppingcart"] as Cart;
            theExistingCart.Items.Clear();

          //  Cart theCart = (Cart)this.Session["cart"];
          //  theCart.Items.Clear();
        }
        protected void Application_Error()
        {

        }
    }
}
