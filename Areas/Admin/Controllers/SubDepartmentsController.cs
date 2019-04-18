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
    public class SubDepartmentsController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: Admin/SubDepartments
        public ActionResult Index()
        {
            var subDepartments = db.SubDepartments;
            return View(subDepartments.ToList());
        }

        // GET: Admin/SubDepartments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubDepartment subDepartment = db.SubDepartments.Find(id);
            if (subDepartment == null)
            {
                return HttpNotFound();
            }
            return View(subDepartment);
        }

        // GET: Admin/SubDepartments/Create
        public ActionResult Create()
        {
            ViewBag.department_id = new SelectList(db.Departments, "id", "name");
            ViewBag.shift_id = new SelectList(db.Shifts, "id", "name");
            return View();
        }

        // POST: Admin/SubDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,department_id,shift_id")] SubDepartment subDepartment)
        {
            if (ModelState.IsValid)
            {
                db.SubDepartments.Add(subDepartment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.department_id = new SelectList(db.Departments, "id", "name", subDepartment.department_id);
            return View(subDepartment);
        }

        // GET: Admin/SubDepartments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubDepartment subDepartment = db.SubDepartments.Find(id);
            if (subDepartment == null)
            {
                return HttpNotFound();
            }
            ViewBag.department_id = new SelectList(db.Departments, "id", "name", subDepartment.department_id);
            return View(subDepartment);
        }

        // POST: Admin/SubDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,department_id,shift_id")] SubDepartment subDepartment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subDepartment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.department_id = new SelectList(db.Departments, "id", "name", subDepartment.department_id);
            return View(subDepartment);
        }

        // GET: Admin/SubDepartments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubDepartment subDepartment = db.SubDepartments.Find(id);
            if (subDepartment == null)
            {
                return HttpNotFound();
            }
            return View(subDepartment);
        }

        // POST: Admin/SubDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubDepartment subDepartment = db.SubDepartments.Find(id);
            db.SubDepartments.Remove(subDepartment);
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
