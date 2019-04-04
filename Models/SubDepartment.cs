using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class SubDepartment
    {
        public int id { get; set; }
        public string name { get; set; }
        public int department_id { get; set; }
        public int shift_id { get; set; }

        [ForeignKey("department_id")]
        public virtual Department department { get; set; }

        [ForeignKey("shift_id")]
        public virtual Shift shift { get; set; }


    }
}