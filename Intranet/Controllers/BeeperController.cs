using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class BeeperController : Controller
    {
        // GET: Beeper
        public ActionResult Index()
        {
            return View();
        }
    }
}