using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sistCedro.Models;
using sistCedro.ViewModels;

namespace sistCedro.Controllers
{
    public class RestPratosController : Controller
    {
        // GET: RestPratos
        ContextoPrato context = new ContextoPrato();
        public ActionResult Index()
        {
            var pratos = from prod in context.Prato select prod;
            var restaurantes = context.Restaurantes.ToList();

            var dados = new RestaurantesxPratos
            {
                Pratos = pratos.ToList<Prato>(),
                Restaurantes = restaurantes
            };

            return View(dados);

        }

        // GET: RestPratos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RestPratos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestPratos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RestPratos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RestPratos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RestPratos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RestPratos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
