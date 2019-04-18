using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AttendanceSystem.Models;
namespace AttendanceSystem.Areas.Admin.Models
{
    public class EmployeeRepository
    {
        public Employee Employee;
        public Personal Personal;
        public Documents Documents;
        public License License;
        public CompanyAssets CompanyAssets;
        public Academic Academic;
        public Experience Experience;
    }
}