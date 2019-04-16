using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class Experience
    {
        public int id { get; set; }
        public string company { get; set; }
        public string designation { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string address { get; set; }

        public int city_id { get; set; }

        [ForeignKey("city_id")]
        public virtual City City { get; set; }
    }
}