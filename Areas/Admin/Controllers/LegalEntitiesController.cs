using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AttendanceSystem.Models;

namespace AttendanceSystem.Areas.Admin.Controllers
{
    public class LegalEntitiesController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: Admin/LegalEntities
        public ActionResult Index()
        {
            return View(db.LegalEntity.ToList());
        }

        // GET: Admin/LegalEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LegalEntity legalEntity = db.LegalEntity.Find(id);
            if (legalEntity == null)
            {
                return HttpNotFound();
            }
            return View(legalEntity);
        }

        // GET: Admin/LegalEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LegalEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name")] LegalEntity legalEntity)
        {
            if (ModelState.IsValid)
            {
                db.LegalEntity.Add(legalEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(legalEntity);
        }

        // GET: Admin/LegalEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LegalEntity legalEntity = db.LegalEntity.Find(id);
            if (legalEntity == null)
            {
                return HttpNotFound();
            }
            return View(legalEntity);
        }

        // POST: Admin/LegalEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name")] LegalEntity legalEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(legalEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(legalEntity);
        }

        // GET: Admin/LegalEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LegalEntity legalEntity = db.LegalEntity.Find(id);
            if (legalEntity == null)
            {
                return HttpNotFound();
            }
            return View(legalEntity);
        }

        // POST: Admin/LegalEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LegalEntity legalEntity = db.LegalEntity.Find(id);
            db.LegalEntity.Remove(legalEntity);
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
