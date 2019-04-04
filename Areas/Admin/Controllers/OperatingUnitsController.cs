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
    public class OperatingUnitsController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: Admin/OperatingUnits
        public ActionResult Index()
        {
            var operatingUnit = db.OperatingUnit.Include(o => o.legalEntity);
            return View(operatingUnit.ToList());
        }

        // GET: Admin/OperatingUnits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperatingUnit operatingUnit = db.OperatingUnit.Find(id);
            if (operatingUnit == null)
            {
                return HttpNotFound();
            }
            return View(operatingUnit);
        }

        // GET: Admin/OperatingUnits/Create
        public ActionResult Create()
        {
            ViewBag.legalEntity_id = new SelectList(db.LegalEntity, "id", "name");
            return View();
        }

        // POST: Admin/OperatingUnits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,legalEntity_id")] OperatingUnit operatingUnit)
        {
            if (ModelState.IsValid)
            {
                db.OperatingUnit.Add(operatingUnit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.legalEntity_id = new SelectList(db.LegalEntity, "id", "name", operatingUnit.legalEntity_id);
            return View(operatingUnit);
        }

        // GET: Admin/OperatingUnits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperatingUnit operatingUnit = db.OperatingUnit.Find(id);
            if (operatingUnit == null)
            {
                return HttpNotFound();
            }
            ViewBag.legalEntity_id = new SelectList(db.LegalEntity, "id", "name", operatingUnit.legalEntity_id);
            return View(operatingUnit);
        }

        // POST: Admin/OperatingUnits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,legalEntity_id")] OperatingUnit operatingUnit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operatingUnit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.legalEntity_id = new SelectList(db.LegalEntity, "id", "name", operatingUnit.legalEntity_id);
            return View(operatingUnit);
        }

        // GET: Admin/OperatingUnits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperatingUnit operatingUnit = db.OperatingUnit.Find(id);
            if (operatingUnit == null)
            {
                return HttpNotFound();
            }
            return View(operatingUnit);
        }

        // POST: Admin/OperatingUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OperatingUnit operatingUnit = db.OperatingUnit.Find(id);
            db.OperatingUnit.Remove(operatingUnit);
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
