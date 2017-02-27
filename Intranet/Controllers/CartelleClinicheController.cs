using Intranet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class CartelleClinicheController : Controller
    {

        public ActionResult Index()
        {
            using (var db = new ApplicationDbContext())
            {
                List<CartelleCliniche> result = db.CartelleCliniche.OrderBy(n => n.NomePaziente).ToList();

                return View(result);
            }
        }

        public ActionResult SpecialIndex()
        {
            return View();
        }



    }
}