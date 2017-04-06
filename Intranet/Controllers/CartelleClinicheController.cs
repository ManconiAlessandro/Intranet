using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Intranet.Models;

namespace Intranet.Controllers
{
    public class CartelleClinicheController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CartelleCliniches
        public ActionResult Index()
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    List<CartelleCliniche> result = db.CartelleCliniche.OrderBy(n => n.Cognome).ToList();

                    return View(result);
                }
            }
            catch
            {
                return View(new List<CartelleCliniche>());
            }
        }

        // GET: CartelleCliniches/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartelleCliniche cartelleCliniche = db.CartelleCliniche.Find(id);
            if (cartelleCliniche == null)
            {
                return HttpNotFound();
            }
            return View(cartelleCliniche);
        }

        // GET: CartelleCliniches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartelleCliniches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDCartellaClinica,NumeroCartellaClinica,Nome,Cognome,href,LuogoDiNascita,DataDiNascita,Eta,Sesso,CodiceFiscale,Cittadinanza,StatoCivile,NomeDelConiuge,ProfessioneAttuale,Residenza,Telefono,InvitatoDa,Peso,Altezza,TipoDiNascita,ManoDominante,TipoDiAllattamento,Allergie,AllergieDescrizione,Convulsioni,Vertigini,Nevralgie,Insonnia,NevrosismoDepressione,VomitoNeurologico,FamiliariPatologieFisiche,FamiliariPatologiePsicologiche,FamiliariPatologiePsichiatriche,PatologieFisicheGravi,PatologiePsicologiche,PatologiePsichiatriche,StoriaRemotaEPresente,Diagnosi,TendenzaAllaViolenza,LivelloConformita")] CartelleCliniche cartelleCliniche)
        {
            if (ModelState.IsValid)
            {
                cartelleCliniche.IDCartellaClinica = Guid.NewGuid();
                cartelleCliniche.href = $"tab-{cartelleCliniche.NumeroCartellaClinica}";
                db.CartelleCliniche.Add(cartelleCliniche);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cartelleCliniche);
        }

        // GET: CartelleCliniches/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartelleCliniche cartelleCliniche = db.CartelleCliniche.Find(id);
            if (cartelleCliniche == null)
            {
                return HttpNotFound();
            }
            return View(cartelleCliniche);
        }

        // POST: CartelleCliniches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDCartellaClinica,NumeroCartellaClinica,Nome,Cognome,href,LuogoDiNascita,DataDiNascita,Eta,Sesso,CodiceFiscale,Cittadinanza,StatoCivile,NomeDelConiuge,ProfessioneAttuale,Residenza,Telefono,InvitatoDa,Peso,Altezza,TipoDiNascita,ManoDominante,TipoDiAllattamento,Allergie,AllergieDescrizione,Convulsioni,Vertigini,Nevralgie,Insonnia,NevrosismoDepressione,VomitoNeurologico,FamiliariPatologieFisiche,FamiliariPatologiePsicologiche,FamiliariPatologiePsichiatriche,PatologieFisicheGravi,PatologiePsicologiche,PatologiePsichiatriche,StoriaRemotaEPresente,Diagnosi,TendenzaAllaViolenza,LivelloConformita")] CartelleCliniche cartelleCliniche)
        {
            if (ModelState.IsValid)
            {
                cartelleCliniche.href = $"tab-{cartelleCliniche.NumeroCartellaClinica}";
                db.Entry(cartelleCliniche).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cartelleCliniche);
        }

        // GET: CartelleCliniches/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartelleCliniche cartelleCliniche = db.CartelleCliniche.Find(id);
            if (cartelleCliniche == null)
            {
                return HttpNotFound();
            }
            return View(cartelleCliniche);
        }

        // POST: CartelleCliniches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CartelleCliniche cartelleCliniche = db.CartelleCliniche.Find(id);
            db.CartelleCliniche.Remove(cartelleCliniche);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
