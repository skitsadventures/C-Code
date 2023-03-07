using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FA_SLD.Models;

namespace FA_SLD.Controllers
{
    public class Cat1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cat1
        public ActionResult Index()
        {
            return View(db.cat1s.ToList());
        }

        // GET: Cat1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat1 cat1 = db.cat1s.Find(id);
            if (cat1 == null)
            {
                return HttpNotFound();
            }
            return View(cat1);
        }

        // GET: Cat1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cat1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Address1,Address2,EmailID")] Cat1 cat1)
        {
            if (ModelState.IsValid)
            {
                db.cat1s.Add(cat1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cat1);
        }

        // GET: Cat1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat1 cat1 = db.cat1s.Find(id);
            if (cat1 == null)
            {
                return HttpNotFound();
            }
            return View(cat1);
        }

        // POST: Cat1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Address1,Address2,EmailID")] Cat1 cat1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cat1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cat1);
        }

        // GET: Cat1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cat1 cat1 = db.cat1s.Find(id);
            if (cat1 == null)
            {
                return HttpNotFound();
            }
            return View(cat1);
        }

        // POST: Cat1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Cat1 cat1 = db.cat1s.Find(id);
            db.cat1s.Remove(cat1);
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
