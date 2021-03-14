using Demo.ASP.MultipleForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.ASP.MultipleForms.Controllers
{
    public class HomeController : Controller
    {
        public static List<Item> items = new List<Item>() { 
            new Item() { Id = 1, Name = "Item 1", IsValid = true},
            new Item() { Id = 2, Name = "Item 2", IsValid = true},
            new Item() { Id = 3, Name = "Item 3", IsValid = true},
            new Item() { Id = 4, Name = "Item 4", IsValid = true},
            new Item() { Id = 5, Name = "Item 5", IsValid = true},
            new Item() { Id = 6, Name = "Item 6", IsValid = true},
            new Item() { Id = 7, Name = "Item 7", IsValid = true},
            new Item() { Id = 8, Name = "Item 8", IsValid = true}
        };
        public ActionResult Index()
        {
            return View(items);
        }

        public ActionResult Toggle(int id)
        {
            items.Where(i => i.Id == id).SingleOrDefault().IsValid = !(items.Where(i => i.Id == id).SingleOrDefault().IsValid);
            return RedirectToAction("Index");
        }
    }
}