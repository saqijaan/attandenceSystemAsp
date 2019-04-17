using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Models
{
    public class Bank
    {
        public int id { get; set; }
        public string name { get; set; }
        public string branch_name { get; set; }

        public int city_id { get; set; }

        [ForeignKey("city_id")]
        public virtual City City { get; set; }
    }
}