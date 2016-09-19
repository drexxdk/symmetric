using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prototype.Controllers
{
    public class AboutUsController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Vision");
        }

        public ActionResult Background()
        {
            return View();
        }
        public ActionResult Values()
        {
            return View();
        }
        public ActionResult Employees()
        {
            return View();
        }
        public ActionResult Vision()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
    }
}