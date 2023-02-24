using Mvc_Web_Proje.Entity;
using Mvc_Web_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Web_Proje.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Card
        public ActionResult Index()
        {
            return View(Getcart());
        }
        public ActionResult AddTocart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);
            if (product!=null)
            {
                Getcart().AddProduct(product,1);
            }



            return RedirectToAction("Index");
        }


        public ActionResult RemoveFromcart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);
            if (product != null)
            {
                Getcart().DeleteProduct(product);
            }



            return RedirectToAction("Index");
        }

        public Cart Getcart()
        {
            var cart = (Cart)Session["Cart"];
            if (cart==null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public PartialViewResult Summary()
        {
            return PartialView(Getcart());
        }
    }
}