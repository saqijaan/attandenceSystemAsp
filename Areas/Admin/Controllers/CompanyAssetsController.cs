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
    public class CompanyAssetsController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: Admin/CompanyAssets
        public ActionResult Index()
        {
            var companyAssets = db.CompanyAssets.Include(c => c.Employee);
            return View(companyAssets.ToList());
        }

        // GET: Admin/CompanyAssets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyAssets companyAssets = db.CompanyAssets.Find(id);
            if (companyAssets == null)
            {
                return HttpNotFound();
            }
            return View(companyAssets);
        }

        // GET: Admin/CompanyAssets/Create
        public ActionResult Create()
        {
            ViewBag.employee_id = new SelectList(db.Employees, "id", "name");
            return View();
        }

        // POST: Admin/CompanyAssets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,details,returnAble,status,employee_id")] CompanyAssets companyAssets)
        {
            if (ModelState.IsValid)
            {
                db.CompanyAssets.Add(companyAssets);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.employee_id = new SelectList(db.Employees, "id", "name", companyAssets.employee_id);
            return View(companyAssets);
        }

        // GET: Admin/CompanyAssets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyAssets companyAssets = db.CompanyAssets.Find(id);
            if (companyAssets == null)
            {
                return HttpNotFound();
            }
            ViewBag.employee_id = new SelectList(db.Employees, "id", "name", companyAssets.employee_id);
            return View(companyAssets);
        }

        // POST: Admin/CompanyAssets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,details,returnAble,status,employee_id")] CompanyAssets companyAssets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyAssets).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.employee_id = new SelectList(db.Employees, "id", "name", companyAssets.employee_id);
            return View(companyAssets);
        }

        // GET: Admin/CompanyAssets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyAssets companyAssets = db.CompanyAssets.Find(id);
            if (companyAssets == null)
            {
                return HttpNotFound();
            }
            return View(companyAssets);
        }

        // POST: Admin/CompanyAssets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompanyAssets companyAssets = db.CompanyAssets.Find(id);
            db.CompanyAssets.Remove(companyAssets);
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
