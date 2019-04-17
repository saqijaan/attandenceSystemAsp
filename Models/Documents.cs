using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class Documents
    {
        public int id { get; set; }

        public string type { get; set; }

        public string name { get; set; }

        public string file { get; set; }

        public int employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual Personal Employee { get; set; }
    }
}