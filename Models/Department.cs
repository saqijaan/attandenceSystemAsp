using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }

        public int operatingUnit_id { get; set; }

        public virtual ICollection<SubDepartment> subDepartments { get; set; }

        [ForeignKey("operatingUnit_id")]
        public virtual OperatingUnit operatingUnit { get; set; }
    }
}