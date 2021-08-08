using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Controllers
{
    public class VendorsController : Controller
    {
        // GET: Vender
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Show(string nom)
        {
            return View();
        }
    }
}