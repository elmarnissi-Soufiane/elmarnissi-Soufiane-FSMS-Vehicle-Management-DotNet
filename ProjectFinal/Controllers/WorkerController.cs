using ProjectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectFinal.Controllers
{
    public class WorkerController : Controller
    {

        public static db_examenwebEntities db = new db_examenwebEntities();
        // GET: Worker
        public ActionResult Index()
        {
            IList<Worker> wrk = db.Workers.ToList();
            return View(wrk);
        }

        // GET: Worker/Details/5
        public ActionResult Details(int id)
        {
            Worker wrk = db.Workers.Single(s => s.Id == id);
            return View(wrk);
        }

        // GET: Worker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Worker/Create
        [HttpPost]
        public ActionResult Create(Worker wrk)
        {
            try
            {
                db.Workers.Add(wrk);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Worker/Edit/5
        public ActionResult Edit(int id)
        {
            Worker wrk = db.Workers.Single(s => s.Id == id);
            return View(wrk);
        }

        // POST: Worker/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Worker newWorker)
        {
            try
            {
                Worker oldWorker = db.Workers.Single(s => s.Id == id);

                oldWorker.cin = newWorker.cin;
                oldWorker.full_name = newWorker.full_name;
                oldWorker.city = newWorker.city;
                oldWorker.phone = newWorker.phone;
                oldWorker.birth_date = newWorker.birth_date;
                oldWorker.start_date = newWorker.start_date;
                oldWorker.job_title = newWorker.job_title;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Worker/Delete/5
        public ActionResult Delete(int id)
        {
            Worker wrk = db.Workers.Single(s => s.Id == id);
            return View(wrk);
        }

        // POST: Worker/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Worker wrk = db.Workers.Single(s => s.Id == id);
                db.Workers.Remove(wrk);
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
