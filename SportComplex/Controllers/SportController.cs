using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCSport.Models;

namespace MVCSport.Controllers
{
    public class SportsController : Controller
    {
        private MVCSportDbsEntities db = new MVCSportDbsEntities();

        // GET: Sports
        public ActionResult Index()
        {
            return View(db.TblSports.ToList());
        }

        // GET: Sports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,fname,lname,age")] TblSport tblSport)
        {
            if (ModelState.IsValid)
            {
                db.TblSports.Add(tblSport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblSport);
        }

        // GET: Sports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblSport tblSport = db.TblSports.Find(id);
            if (tblSport == null)
            {
                return HttpNotFound();
            }
            return View(tblSport);
        }

        // POST: Sports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,fname,lname,age")] TblSport tblSport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblSport);
        }

        // GET: Sports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblSport tblSport = db.TblSports.Find(id);
            if (tblSport == null)
            {
                return HttpNotFound();
            }
            return View(tblSport);
        }

        // POST: Sports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblSport tblSport = db.TblSports.Find(id);
            db.TblSports.Remove(tblSport);
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
