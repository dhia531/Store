using Store.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class BlogController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        // GET: Blog
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            var list = db.BlogContext.ToList();
            return View(list);
        }

        public ActionResult Show(Guid Id)
        {
            var item = db.BlogContext.Find(Id);
            return View(item);
        }

        public ActionResult create()
        {
            var blog = new Store.Entities.Blog();
            blog.Name = "Article 1";
            blog.Summary = "Summer 1";
            blog.Description = "description 1";
            blog.ImageFile = "https://images.pexels.com/photos/736230/pexels-photo-736230.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500";
            db.Entry(blog).State = EntityState.Added;
            db.SaveChanges();
          
            return View();
        }
    }
}