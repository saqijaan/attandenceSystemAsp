﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        //[Column(TypeName = "DateTime2")]
        public string dob { get; set; }

        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string image { get; set; }
        public string phone { get; set; }
        public string emergencyPhone { get; set; }
        public string cnic { get; set; }
        public string detail { get; set; }
        public string religion { get; set; }
        public Boolean dislabled { get; set; }
        public string bloodGroup { get; set; }
        public string bankAcc { get; set; }
        public string experience { get; set; }


        /**
         * All Foreign Keys
         * */
        public int department_id { get; set; }
        public int subDepartment_id { get; set; }


        /**
         * All Relationships
         * */

        [ForeignKey("department_id")]
        public virtual Department department { get; set; }

        public virtual ICollection<Documents> documents { get; set; }
        public virtual ICollection<License> licenses { get; set; }
        public virtual ICollection<CompanyAssets> companyAssets { get; set; }
        public virtual ICollection<Academic> academics { get; set; }
    }
}