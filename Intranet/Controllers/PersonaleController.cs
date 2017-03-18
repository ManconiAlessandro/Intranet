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
    public class PersonaleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Personales
        public ActionResult Index()
        {
            using (var db = new ApplicationDbContext())
            {
                List<Personale> result = db.Personale.OrderBy(n => n.Cognome).ToList();

                return View(result);
            }
        }

        // GET: Personales/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personale personale = db.Personale.Find(id);
            if (personale == null)
            {
                return HttpNotFound();
            }
            return View(personale);
        }

        // GET: Personales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDPersonale,NumeroMatricola,Nome,Cognome,href,LuogoDiNascita,DataDiNascita,Eta,Sesso,CodiceFiscale,Cittadinanza,StatoCivile,NomeDelConiuge,ProfessioneAttuale,Residenza,Telefono,InvitatoDa,Peso,Altezza,CarichiPendentiEsito,CarichiPendentiDescrizione")] Personale personale)
        {
            if (ModelState.IsValid)
            {
                personale.IDPersonale = Guid.NewGuid();
                personale.href = $"tab-{personale.NumeroMatricola}";
                db.Personale.Add(personale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personale);
        }

        // GET: Personales/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personale personale = db.Personale.Find(id);
            if (personale == null)
            {
                return HttpNotFound();
            }
            return View(personale);
        }

        // POST: Personales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPersonale,NumeroMatricola,Nome,Cognome,href,LuogoDiNascita,DataDiNascita,Eta,Sesso,CodiceFiscale,Cittadinanza,StatoCivile,NomeDelConiuge,ProfessioneAttuale,Residenza,Telefono,InvitatoDa,Peso,Altezza,CarichiPendentiEsito,CarichiPendentiDescrizione")] Personale personale)
        {
            if (ModelState.IsValid)
            {
                personale.href = $"tab-{personale.NumeroMatricola}";
                db.Entry(personale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personale);
        }

        // GET: Personales/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personale personale = db.Personale.Find(id);
            if (personale == null)
            {
                return HttpNotFound();
            }
            return View(personale);
        }

        // POST: Personales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Personale personale = db.Personale.Find(id);
            db.Personale.Remove(personale);
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
