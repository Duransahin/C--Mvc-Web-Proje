using Mvc_Web_Proje.Entity;
using Mvc_Web_Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Web_Proje.Controllers
{
    public class HomeController : Controller
    {
        DataContext context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urunler = context.Products.Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id=i.Id,
                    Name=i.Name,
                    Description=i.Description.Length>50? i.Description.Substring(0,50)+"...":i.Description,
                    Price=i.Price,
                    Stock=i.Stock,
                    Image=i.Image,
                    CategoryId=i.CategoryId

                }).ToList();
            return View(urunler);
    
        }
        public ActionResult Details(int id)
        {
            return View(context.Products.Where(i => i.Id == id).FirstOrDefault());//Burada firstordefault diyerek sadece bir değer göndereceğimizi söylemiş oluyoruz
        }
        public ActionResult List(int? id)
        {
            var urunler = context.Products.Where(i => i.IsApproved)
                 .Select(i => new ProductModel()
                 {
                     Id = i.Id,
                     Name = i.Name.Length > 50 ? i.Name.Substring(0, 50) + "..." : i.Name,
                     Description = i.Description.Length > 50 ? i.Description.Substring(0, 50) + "..." : i.Description,
                     Price = i.Price,
                     Stock = i.Stock,
                     Image = i.Image ?? "2.jpg",
                     CategoryId = i.CategoryId

                 }).AsQueryable();
            if (id!= null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }
            return View(urunler.ToList());
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(context.Categories.ToList());
        }
    }
}