using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcFoad2024_2.Models;
using PagedList;
using MvcFoad2024_2.App_Start;


namespace MvcFoad2024_2.Controllers
{
    public class AuteursController : Controller
    {
        private bdMemorySharedContext db = new bdMemorySharedContext();
        Util Util = new Util();
        private int sizePage = 1;

        // GET: Auteurs
        public ActionResult Index(int? page)
        {
            page = page.HasValue ? page : 1;
            var lesAuteurs = db.auteurs.ToList();
            int pageNumner = (page ?? 1);
            return View(lesAuteurs.ToPagedList(pageNumner, sizePage));
        }

        public DataTable GetTableAuteur()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Anciennete", typeof(int));
            table.Columns.Add("NomUtilisateur", typeof(string));
            table.Columns.Add("PrenomUtilisateur", typeof(string));
            table.Columns.Add("TelUtilisateur", typeof(string));
            table.Columns.Add("EmailUtilisateur", typeof(string));
            table.Columns.Add("MatriculeUtilisateur", typeof(string));
            table.Columns.Add("EtatUtilisateur", typeof(string));
            var auteurs = db.auteurs.ToList();
            foreach( var a in auteurs )
            {
                table.Rows.Add(a.Anciennete, a.NomUtilisateur, a.PrenomUtilisateur, a.TelUtilisateur, a.EmailUtilisateur, a.MatriculeUtilisateur, a.EtatUtilisateur);
            }
            
            return table;
        }


        public ActionResult PrintAuteur()
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                rpt.Load(Server.MapPath("~/Report/rptListeAuteurs.rpt"));
                rpt.SetDataSource(GetTableAuteur());
                Stream stream = rpt.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                Response.AppendHeader("Content-Disposition", "inline");
                return File(stream, "application/pdf");
            }
            catch (Exception ex)
            {
                Util.WriteDataError("Auteur-PrintAuteur", ex.ToString());
                return null;
            }

            finally
            {
                rpt.Dispose();
                rpt.Close();
            }
        }


        // GET: Auteurs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auteur auteur = db.auteurs.Find(id);
            if (auteur == null)
            {
                return HttpNotFound();
            }
            return View(auteur);
        }

        // GET: Auteurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auteurs/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdUtilisateur,NomUtilisateur,PrenomUtilisateur,TelUtilisateur,EmailUtilisateur,MotDePasseUtilisateur,MatriculeUtilisateur,EtatUtilisateur,Anciennete")] Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                db.utilisateurs.Add(auteur);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auteur);
        }

        // GET: Auteurs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auteur auteur = db.auteurs.Find(id);
            if (auteur == null)
            {
                return HttpNotFound();
            }
            return View(auteur);
        }

        // POST: Auteurs/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdUtilisateur,NomUtilisateur,PrenomUtilisateur,TelUtilisateur,EmailUtilisateur,MotDePasseUtilisateur,MatriculeUtilisateur,EtatUtilisateur,Anciennete")] Auteur auteur)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auteur).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auteur);
        }

        // GET: Auteurs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auteur auteur = db.auteurs.Find(id);
            if (auteur == null)
            {
                return HttpNotFound();
            }
            return View(auteur);
        }

        // POST: Auteurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Auteur auteur = db.auteurs.Find(id);
            db.utilisateurs.Remove(auteur);
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
