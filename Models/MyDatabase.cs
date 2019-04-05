using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace AttendanceSystem.Models
{
    public class MyDatabase : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<SubDepartment> SubDepartments { get; set; }
        public DbSet<LegalEntity> LegalEntity { get; set; }
        public DbSet<OperatingUnit> OperatingUnit { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MyDatabase>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}