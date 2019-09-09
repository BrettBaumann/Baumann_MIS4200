using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baumann_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "All about Brett";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact info for Brett Baumann";

            return View();
        }
    }
}