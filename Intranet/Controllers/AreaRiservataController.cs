using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class AreaRiservataController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string pass)
        {
            if (pass == "test")
                return RedirectToAction("RealIndex","Farmaci");
            else
            {
                ViewBag.Error = "Password Errata!";
                return View();

            }
        }

    }
}