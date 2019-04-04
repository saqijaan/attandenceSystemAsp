using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime dob { get; set; }

        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string image { get; set; }
        public string phone { get; set; }
        public string emergencyPhone { get; set; }
        public string cnic { get; set; }
        public string detail { get; set; }
        public string religion { get; set; }
        public Boolean dislabled { get; set; }
        public string bloodGroup { get; set; }
        public string bankAcc { get; set; }
        public string experience { get; set; }

        public int department_id { get; set; }
        public int shift_id { get; set; }
        public int subDepartment_id { get; set; }

        [ForeignKey("shift_id")]
        public virtual Shift shift { get; set; }

        [ForeignKey("department_id")]
        public virtual Department department { get; set; }

    }
}