using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcFoad2024_2;
using MvcFoad2024_2.Models;

using PagedList;

namespace MvcFoad2024_2.Controllers
{
    public class LecteursController : Controller
    {
        private bdMemorySharedContext db = new bdMemorySharedContext();
        private int sizePage = 1;
        // GET: Lecteurs
        public ActionResult Index(int? page )
        {
            page = page.HasValue ? page : 1;
            var lesLecteurs = db.lecteurs.ToList();
            int pageNumner = (page ?? 1);
            return View(lesLecteurs.ToPagedList(pageNumner, sizePage));
           
        }

        // GET: Lecteurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lecteur lecteur = db.lecteurs.Find(id);
            if (lecteur == null)
            {
                return HttpNotFound();
            }
            return View(lecteur);
        }

        // GET: Lecteurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lecteurs/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUtilisateur,NomUtilisateur,PrenomUtilisateur,TelUtilisateur,EmailUtilisateur,MotDePasseUtilisateur,MatriculeUtilisateur,EtatUtilisateur,specialite")] Lecteur lecteur)
        {
            if (ModelState.IsValid)
            {
                db.utilisateurs.Add(lecteur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lecteur);
        }

        // GET: Lecteurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lecteur lecteur = db.lecteurs.Find(id);
            if (lecteur == null)
            {
                return HttpNotFound();
            }
            return View(lecteur);
        }

        // POST: Lecteurs/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUtilisateur,NomUtilisateur,PrenomUtilisateur,TelUtilisateur,EmailUtilisateur,MotDePasseUtilisateur,MatriculeUtilisateur,EtatUtilisateur,specialite")] Lecteur lecteur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lecteur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lecteur);
        }

        // GET: Lecteurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lecteur lecteur = db.lecteurs.Find(id);
            if (lecteur == null)
            {
                return HttpNotFound();
            }
            return View(lecteur);
        }

        // POST: Lecteurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lecteur lecteur = db.lecteurs.Find(id);
            db.utilisateurs.Remove(lecteur);
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
