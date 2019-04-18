using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AttendanceSystem.Models;

namespace AttendanceSystem.Areas.Admin.Views.Employees
{
    public class PersonalsController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: Admin/Personals
        public ActionResult Index()
        {
            var personal = db.Personal.Include(p => p.Bank).Include(p => p.BloodGroup).Include(p => p.MeritalStatus);
            return View(personal.ToList());
        }

        // GET: Admin/Personals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            return View(personal);
        }

        // GET: Admin/Personals/Create
        public ActionResult Create()
        {
            ViewBag.bank_id = new SelectList(db.Banks, "id", "name");
            ViewBag.bloodGroup_id = new SelectList(db.BloodGroups, "id", "name");
            ViewBag.meritalStatus_id = new SelectList(db.MeritalStatus, "id", "name");
            return View();
        }

        // POST: Admin/Personals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,first_name,middel_name,last_name,dob,gender,father_name,address,country,nationality,image,phone,emergencyPhone,cnic,cnicExpiry,detail,religion,disabled,identification,email,mobileNo,placeofBirth,bankAccNo,experience,height,weight,ntnNo,sessi,eobi,motherMaidenName,khandanNo,emerContact_name,emerContact_no,emerContact_relation,emerContact_adderess,beni_name,beni_relation,beni_share,isConvictedBycourt,passportNo,passportPlace,passportExpiryDate,created_at,updated_at,bloodGroup_id,meritalStatus_id,bank_id")] Personal personal)
        {
            if (ModelState.IsValid)
            {
                db.Personal.Add(personal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.bank_id = new SelectList(db.Banks, "id", "name", personal.bank_id);
            ViewBag.bloodGroup_id = new SelectList(db.BloodGroups, "id", "name", personal.bloodGroup_id);
            ViewBag.meritalStatus_id = new SelectList(db.MeritalStatus, "id", "name", personal.meritalStatus_id);
            return View(personal);
        }

        // GET: Admin/Personals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            ViewBag.bank_id = new SelectList(db.Banks, "id", "name", personal.bank_id);
            ViewBag.bloodGroup_id = new SelectList(db.BloodGroups, "id", "name", personal.bloodGroup_id);
            ViewBag.meritalStatus_id = new SelectList(db.MeritalStatus, "id", "name", personal.meritalStatus_id);
            return View(personal);
        }

        // POST: Admin/Personals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,first_name,middel_name,last_name,dob,gender,father_name,address,country,nationality,image,phone,emergencyPhone,cnic,cnicExpiry,detail,religion,disabled,identification,email,mobileNo,placeofBirth,bankAccNo,experience,height,weight,ntnNo,sessi,eobi,motherMaidenName,khandanNo,emerContact_name,emerContact_no,emerContact_relation,emerContact_adderess,beni_name,beni_relation,beni_share,isConvictedBycourt,passportNo,passportPlace,passportExpiryDate,created_at,updated_at,bloodGroup_id,meritalStatus_id,bank_id")] Personal personal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.bank_id = new SelectList(db.Banks, "id", "name", personal.bank_id);
            ViewBag.bloodGroup_id = new SelectList(db.BloodGroups, "id", "name", personal.bloodGroup_id);
            ViewBag.meritalStatus_id = new SelectList(db.MeritalStatus, "id", "name", personal.meritalStatus_id);
            return View(personal);
        }

        // GET: Admin/Personals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            return View(personal);
        }

        // POST: Admin/Personals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personal personal = db.Personal.Find(id);
            db.Personal.Remove(personal);
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
