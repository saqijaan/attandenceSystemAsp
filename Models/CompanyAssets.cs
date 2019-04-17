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

        public string type { get; set; }

        public double qty { get; set; }
        public string serial_no { get; set; }
        public string plate_no { get; set; }
        public string hand_over_date { get; set; }
        public string hand_over_by { get; set; }
        public string recover_date { get; set; }
        public string recover_by { get; set; }

        public int employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual Personal Employee { get; set; }
    }
} 