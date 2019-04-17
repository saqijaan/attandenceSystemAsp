using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class Reference
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string designation { get; set; }
        public string contact_no { get; set; }

        public int employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual Personal Employee { get; set; }
    }
}