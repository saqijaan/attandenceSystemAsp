using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Models
{
    public class CompanyAssets
    {
        public int id { get; set; }
        public string name { get; set; }

        public string details { get; set; }

        public bool returnAble { get; set; }
        public bool status { get; set; }

        public int employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual Employee Employee { get; set; }
    }
} 