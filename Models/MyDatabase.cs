using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.Entity;
namespace AttendanceSystem.Models
{
   [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyDatabase : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<SubDepartment> SubDepartments { get; set; }
        public DbSet<LegalEntity> LegalEntity { get; set; }
        public DbSet<OperatingUnit> OperatingUnit { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<CompanyAssets> CompanyAssets { get; set; }
        public DbSet<Academic> Academics { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }

        public DbSet<TransferType> TransferTypes { get; set; }
        public DbSet<LeavePlanType> LeaveTypes { get; set; }
        public DbSet<EmploymentType> EmployementTypes { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }
        public DbSet<HeadOffice> HeadOffices { get; set; }

        public System.Data.Entity.DbSet<AttendanceSystem.Models.MeritalStatus> MeritalStatus { get; set; }
    }
}