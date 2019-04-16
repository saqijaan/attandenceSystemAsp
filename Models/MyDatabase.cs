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
        public DbSet<Documents> Documents { get; set; }
        public DbSet<License> Licenses { get; set; }
        public DbSet<CompanyAssets> CompanyAssets { get; set; }
        public DbSet<Academic> Academics { get; set; }
        public DbSet<Reference> Reference { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankBranch> BankBranch { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }

    }
}