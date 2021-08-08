using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class ElementController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Element");
        }
        // GET: Element
        public ActionResult Element(string name)
        {
            return View();
        }
        public ActionResult Instagram()
        {
            return View();
        }
       

    }
}