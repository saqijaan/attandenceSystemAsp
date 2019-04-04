using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceSystem.Models
{
    public class Shift
    {
        public int id { get; set; }
        public string name { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string check_in_time { get; set; }
        public string check_out_time { get; set; }
        public string early_min { get; set; }
        public string late_min { get; set; }
        public virtual ICollection<SubDepartment> subDepartments { get; set; }
    }
}