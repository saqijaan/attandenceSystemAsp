using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class BankBranch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public int bank_id { get; set; }
        public int city_id { get; set; }

        [ForeignKey("bank_id")]
        public virtual Bank Bank { get; set; }

        [ForeignKey("city_id")]
        public virtual City City { get; set; }
    }
}