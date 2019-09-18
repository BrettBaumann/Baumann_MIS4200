using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baumann_MIS4200.DAL;
using baumann_MIS4200.Models;

namespace baumann_MIS4200.Controllers
{
    public class AutomobilesController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: Automobiles
        public ActionResult Index()
        {
            return View(db.AutomobileInfo.ToList());
        }

        // GET: Automobiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.AutomobileInfo.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // GET: Automobiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automobiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "automobileID,make,model,year")] Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                db.AutomobileInfo.Add(automobile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(automobile);
        }

        // GET: Automobiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.AutomobileInfo.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // POST: Automobiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "automobileID,make,model,year")] Automobile automobile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automobile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(automobile);
        }

        // GET: Automobiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobile automobile = db.AutomobileInfo.Find(id);
            if (automobile == null)
            {
                return HttpNotFound();
            }
            return View(automobile);
        }

        // POST: Automobiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automobile automobile = db.AutomobileInfo.Find(id);
            db.AutomobileInfo.Remove(automobile);
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
