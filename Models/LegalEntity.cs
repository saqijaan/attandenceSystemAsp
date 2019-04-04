using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceSystem.Models
{
    public class LegalEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<OperatingUnit> operatingUnits { get; set; }
    }
}