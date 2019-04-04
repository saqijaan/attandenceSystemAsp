using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class OperatingUnit
    {
        public int id { get; set; }
        public string name { get; set; }

        public int legalEntity_id { get; set; }

        [ForeignKey("legalEntity_id")]
        public virtual LegalEntity legalEntity { get; set; }
        public virtual ICollection<Department> departments { get; set; }
    }
}