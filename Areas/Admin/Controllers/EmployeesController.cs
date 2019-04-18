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
    public class EmployeesController : Controller
    {
        private MyDatabase db = new MyDatabase();

        // GET: Admin/Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Department).Include(e => e.Designation).Include(e => e.EmploymentType).Include(e => e.Grade).Include(e => e.HeadOffice).Include(e => e.JobStatus).Include(e => e.LeavePlanType).Include(e => e.Shift).Include(e => e.SubDepartment).Include(e => e.TransferType);
            return View(employees.ToList());
        }

        // GET: Admin/Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Admin/Employees/Create
        public ActionResult Create()
        {
            ViewBag.department_id = new SelectList(db.Departments, "id", "name");
            ViewBag.designation_id = new SelectList(db.Designations, "id", "name");
            ViewBag.employementType_id = new SelectList(db.EmployementTypes, "id", "name");
            ViewBag.grade_id = new SelectList(db.Grades, "id", "name");
            ViewBag.head_id = new SelectList(db.HeadOffices, "id", "name");
            ViewBag.jobStatus_id = new SelectList(db.JobStatuses, "id", "name");
            ViewBag.leavePlanType_id = new SelectList(db.LeaveTypes, "id", "id");
            ViewBag.shift_id = new SelectList(db.Shifts, "id", "name");
            ViewBag.sub_department_id = new SelectList(db.SubDepartments, "id", "name");
            ViewBag.transferType_id = new SelectList(db.TransferTypes, "id", "name");
            return View();
        }

        // POST: Admin/Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,isShadow,isRejoin,hiringDate,joiningDate,confirmationDate,expiryDate,noticePeriod,noticePeriodStartDate,resonForLeaving,payscale,basicPay,postingDate,dailyWagerRate,grossSalary,createdDate,joiningLetterDate,idCardIssuanceDate,healthCardIssuanceDate,eobCardIssuanceDate,probationPeriod,idCardExpiryDate,contractExpiryDate,isInterestBased,isZakatBased,professionalTaxAmount,eligibleForTaxInLastYear,extendProbation,department_id,sub_department_id,shift_id,employementType_id,jobStatus_id,designation_id,head_id,grade_id,leavePlanType_id,transferType_id")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.department_id = new SelectList(db.Departments, "id", "name", employee.department_id);
            ViewBag.designation_id = new SelectList(db.Designations, "id", "name", employee.designation_id);
            ViewBag.employementType_id = new SelectList(db.EmployementTypes, "id", "name", employee.employementType_id);
            ViewBag.grade_id = new SelectList(db.Grades, "id", "name", employee.grade_id);
            ViewBag.head_id = new SelectList(db.HeadOffices, "id", "name", employee.head_id);
            ViewBag.jobStatus_id = new SelectList(db.JobStatuses, "id", "name", employee.jobStatus_id);
            ViewBag.leavePlanType_id = new SelectList(db.LeaveTypes, "id", "id", employee.leavePlanType_id);
            ViewBag.shift_id = new SelectList(db.Shifts, "id", "name", employee.shift_id);
            ViewBag.sub_department_id = new SelectList(db.SubDepartments, "id", "name", employee.sub_department_id);
            ViewBag.transferType_id = new SelectList(db.TransferTypes, "id", "name", employee.transferType_id);
            return View(employee);
        }

        // GET: Admin/Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.department_id = new SelectList(db.Departments, "id", "name", employee.department_id);
            ViewBag.designation_id = new SelectList(db.Designations, "id", "name", employee.designation_id);
            ViewBag.employementType_id = new SelectList(db.EmployementTypes, "id", "name", employee.employementType_id);
            ViewBag.grade_id = new SelectList(db.Grades, "id", "name", employee.grade_id);
            ViewBag.head_id = new SelectList(db.HeadOffices, "id", "name", employee.head_id);
            ViewBag.jobStatus_id = new SelectList(db.JobStatuses, "id", "name", employee.jobStatus_id);
            ViewBag.leavePlanType_id = new SelectList(db.LeaveTypes, "id", "id", employee.leavePlanType_id);
            ViewBag.shift_id = new SelectList(db.Shifts, "id", "name", employee.shift_id);
            ViewBag.sub_department_id = new SelectList(db.SubDepartments, "id", "name", employee.sub_department_id);
            ViewBag.transferType_id = new SelectList(db.TransferTypes, "id", "name", employee.transferType_id);
            return View(employee);
        }

        // POST: Admin/Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,isShadow,isRejoin,hiringDate,joiningDate,confirmationDate,expiryDate,noticePeriod,noticePeriodStartDate,resonForLeaving,payscale,basicPay,postingDate,dailyWagerRate,grossSalary,createdDate,joiningLetterDate,idCardIssuanceDate,healthCardIssuanceDate,eobCardIssuanceDate,probationPeriod,idCardExpiryDate,contractExpiryDate,isInterestBased,isZakatBased,professionalTaxAmount,eligibleForTaxInLastYear,extendProbation,department_id,sub_department_id,shift_id,employementType_id,jobStatus_id,designation_id,head_id,grade_id,leavePlanType_id,transferType_id")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.department_id = new SelectList(db.Departments, "id", "name", employee.department_id);
            ViewBag.designation_id = new SelectList(db.Designations, "id", "name", employee.designation_id);
            ViewBag.employementType_id = new SelectList(db.EmployementTypes, "id", "name", employee.employementType_id);
            ViewBag.grade_id = new SelectList(db.Grades, "id", "name", employee.grade_id);
            ViewBag.head_id = new SelectList(db.HeadOffices, "id", "name", employee.head_id);
            ViewBag.jobStatus_id = new SelectList(db.JobStatuses, "id", "name", employee.jobStatus_id);
            ViewBag.leavePlanType_id = new SelectList(db.LeaveTypes, "id", "id", employee.leavePlanType_id);
            ViewBag.shift_id = new SelectList(db.Shifts, "id", "name", employee.shift_id);
            ViewBag.sub_department_id = new SelectList(db.SubDepartments, "id", "name", employee.sub_department_id);
            ViewBag.transferType_id = new SelectList(db.TransferTypes, "id", "name", employee.transferType_id);
            return View(employee);
        }

        // GET: Admin/Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Admin/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
