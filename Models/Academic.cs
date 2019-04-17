using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Models
{
    public class Academic
    {
        public int id { get; set; }

        public string degree { get; set; }
        public string borad { get; set; }
        public string total_marks { get; set; }
        public string obtain_marks { get; set; }
        public string passing_year { get; set; }

        public int employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual Personal Employee { get; set; }

    }
}