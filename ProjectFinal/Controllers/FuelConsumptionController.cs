using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFinal.Controllers
{
    public class FuelConsumptionController : Controller
    {
        // GET: FuelConsumption
        public ActionResult Index()
        {
            return View();
        }

        // GET: FuelConsumption/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FuelConsumption/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FuelConsumption/Create
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

        // GET: FuelConsumption/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FuelConsumption/Edit/5
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

        // GET: FuelConsumption/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FuelConsumption/Delete/5
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
