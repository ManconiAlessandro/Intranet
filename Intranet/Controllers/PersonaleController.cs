using Intranet.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Intranet.Controllers
{
    public class PersonaleController : Controller
    {

        public ActionResult Index()
        {

            using (var db = new ApplicationDbContext())
            {
                List<Personale> result = db.Personale.OrderBy(n => n.NomeAddetto).ToList();

                return View(result);
            }
        }
     
       

	}
}