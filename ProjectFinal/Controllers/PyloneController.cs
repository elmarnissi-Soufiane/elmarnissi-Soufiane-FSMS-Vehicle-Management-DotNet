using ProjectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ProjectFinal.Controllers
{
    public class PyloneController : Controller
    {

        public static db_examenwebEntities db = new db_examenwebEntities();
        // GET: Pylone
        public ActionResult Index()
        {
            IList<Pylone> pl = db.Pylones.ToList();
            return View(pl);
        }

        // GET: Pylone/Details/5
        public ActionResult Details(int id)
        {
            Pylone pl = db.Pylones.Single(s => s.Id == id);
            return View(pl);
        }

        // GET: Pylone/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pylone/Create
        [HttpPost]
        public ActionResult Create(Pylone pl)
        {
            try
            {

                db.Pylones.Add(pl);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pylone/Edit/5
        public ActionResult Edit(int id)
        {
            Pylone pl = db.Pylones.Single(s => s.Id == id);
            return View(pl);
        }

        // POST: Pylone/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pylone plnew)
        {
            try
            {
                Pylone oldPulone = db.Pylones.Single(s => s.Id == id);

                oldPulone.number = plnew.number;
                oldPulone.line = plnew.line;
                oldPulone.city = plnew.city;
                oldPulone.latitude = plnew.latitude;
                oldPulone.longitude = plnew.longitude;
                oldPulone.degradation = plnew.degradation;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pylone/Delete/5
        public ActionResult Delete(int id)
        {
            Pylone pl = db.Pylones.Single(s => s.Id == id);
            return View(pl);
        }

        // POST: Pylone/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Pylone pl = db.Pylones.Single(s => s.Id == id);
                db.Pylones.Remove(pl);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
