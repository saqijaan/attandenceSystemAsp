using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class LegalEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public string address { get; set; }
        public string contact_person { get; set; }
        public string mobile { get; set; }
        public string nic { get; set; }

        public int? city_id { get; set; }
        public int bloodgroup_id { get; set; }

        [ForeignKey("city_id")]
        public virtual City City { get; set; }

        [ForeignKey("bloodgroup_id")]
        public virtual BloodGroup BloodGroup { get; set; }

        public virtual ICollection<OperatingUnit> operatingUnits { get; set; }
    }
}