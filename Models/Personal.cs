using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace AttendanceSystem.Models
{
    public class Personal
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string middel_name { get; set; }
        public string last_name { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string father_name { get; set; }

        public string address { get; set; }
        public string country { get; set; }
        public string nationality { get; set; }

        public string image { get; set; }
        public string phone { get; set; }
        public string emergencyPhone { get; set; }
        public string cnic { get; set; }
        public string cnicExpiry { get; set; }
        public string detail { get; set; }
        public string religion { get; set; }
        public bool disabled { get; set; }
        public string identification { get; set; }
        public string email { get; set; }
        public string mobileNo { get; set; }
        public string placeofBirth { get; set; }
        public string bankAccNo { get; set; }
        public string experience { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string ntnNo { get; set; }
        public string sessi { get; set; }
        public string eobi { get; set; }
        public string motherMaidenName { get; set; }
        public string khandanNo { get; set; }
        public string emerContact_name { get; set; }
        public string emerContact_no { get; set; }
        public string emerContact_relation { get; set; }
        public string emerContact_adderess { get; set; }
        public string beni_name { get; set; }
        public string beni_relation { get; set; }
        public string beni_share { get; set; }
        public bool isConvictedBycourt { get; set; }

        public string passportNo { get; set; }
        public string passportPlace { get; set; }
        public string passportExpiryDate { get; set; }

        public string created_at { get; set; }
        public string updated_at { get; set; }

        /**
         * All Foreign Keys
         * */
        public int bloodGroup_id { get; set; }
        public int meritalStatus_id { get; set; }
        public int bank_id { get; set; }


        /**
         * All Relationships
         * */

        [ForeignKey("bloodGroup_id")]
        public virtual BloodGroup BloodGroup { get; set; }
        [ForeignKey("meritalStatus_id")]
        public virtual MeritalStatus MeritalStatus { get; set; }
        [ForeignKey("bank_id")]
        public virtual Bank Bank { get; set; }

        public virtual ICollection<Documents> documents { get; set; }
        public virtual ICollection<License> licenses { get; set; }
        public virtual ICollection<CompanyAssets> companyAssets { get; set; }
        public virtual ICollection<Academic> academics { get; set; }
        public virtual ICollection<Reference> references { get; set; }
    }
}