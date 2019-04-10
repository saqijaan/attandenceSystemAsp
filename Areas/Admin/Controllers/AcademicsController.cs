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
    public class AcademicsController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: Admin/Academics
        public ActionResult Index()
        {
            var academics = db.Academics.Include(a => a.Employee);
            return View(academics.ToList());
        }

        // GET: Admin/Academics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = db.Academics.Find(id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        // GET: Admin/Academics/Create
        public ActionResult Create(int id)
        {
            ViewBag.employee_id = new SelectList(db.Employees, "id", "name");
            ViewBag.empId = id;
            return View();
        }

        // POST: Admin/Academics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,degree,borad,total_marks,obtain_marks,passing_year,employee_id")] Academic academic)
        {
            if (ModelState.IsValid)
            {
                db.Academics.Add(academic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.employee_id = new SelectList(db.Employees, "id", "name", academic.employee_id);
            return View(academic);
        }

        // GET: Admin/Academics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = db.Academics.Find(id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            ViewBag.employee_id = new SelectList(db.Employees, "id", "name", academic.employee_id);
            return View(academic);
        }

        // POST: Admin/Academics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,degree,borad,total_marks,obtain_marks,passing_year,employee_id")] Academic academic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(academic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.employee_id = new SelectList(db.Employees, "id", "name", academic.employee_id);
            return View(academic);
        }

        // GET: Admin/Academics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Academic academic = db.Academics.Find(id);
            if (academic == null)
            {
                return HttpNotFound();
            }
            return View(academic);
        }

        // POST: Admin/Academics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Academic academic = db.Academics.Find(id);
            db.Academics.Remove(academic);
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
