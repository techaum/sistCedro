using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sistCedro.Models;

namespace sistCedro.Controllers
{
    public class PratoesController : Controller
    {
        private ContextoPrato db = new ContextoPrato();

        // GET: Pratoes
        public ActionResult Index()
        {
            var prato = db.Prato.Include(p => p.Restaurante);

            return View(prato.ToList());
        }

        // GET: Pratoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prato prato = db.Prato.Find(id);
            if (prato == null)
            {
                return HttpNotFound();
            }
            return View(prato);
        }

        // GET: Pratoes/Create
        public ActionResult Create()
        {

            ViewBag.Topico = new SelectList(db.Restaurantes, "Id", "nomeRestaurante");

            return View();
        }

        // POST: Pratoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nomePrato,precoPrato,IdRestaurante")] Prato prato)
        {
            if (ModelState.IsValid)
            {
                db.Prato.Add(prato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Topico = new SelectList(db.Restaurantes, "Id", "nomeRestaurante");

            return View(prato);
        }

        // GET: Pratoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prato prato = db.Prato.Find(id);
            if (prato == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdRestaurante = new SelectList(db.Restaurantes, "Id", "nomeRestaurante", prato.IdRestaurante);
            return View(prato);
        }

        // POST: Pratoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nomePrato,precoPrato,IdRestaurante")] Prato prato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdRestaurante = new SelectList(db.Restaurantes, "Id", "nomeRestaurante", prato.IdRestaurante);
            return View(prato);
        }

        // GET: Pratoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prato prato = db.Prato.Find(id);
            if (prato == null)
            {
                return HttpNotFound();
            }
            return View(prato);
        }

        // POST: Pratoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prato prato = db.Prato.Find(id);
            db.Prato.Remove(prato);
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
