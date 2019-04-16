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
        public string address { get; set; }
        public string location { get; set; }
        public string region { get; set; }
        public string unit_type { get; set; }
        public string unit_subtype { get; set; }

        public int city_id { get; set; }
        public int legalEntity_id { get; set; }

        [ForeignKey("city_id")]
        public virtual City City { get; set; }

        [ForeignKey("legalEntity_id")]
        public virtual LegalEntity legalEntity { get; set; }

        public virtual ICollection<Department> departments { get; set; }
    }
}