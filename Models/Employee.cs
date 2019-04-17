using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceSystem.Models
{
    public class Employee
    {
        public int id { get; set; }
        public bool isShadow { get; set; }
        public bool isRejoin { get; set; }
        public string hiringDate { get; set; }
        public string joiningDate { get; set; }
        public string confirmationDate { get; set; }
        public string expiryDate { get; set; }
        public string noticePeriod { get; set; }
        public string noticePeriodStartDate { get; set; }
        public string resonForLeaving { get; set; }
        public string payscale { get; set; }
        public string basicPay { get; set; }
        public string postingDate { get; set; }
        public string dailyWagerRate { get; set; }
        public string grossSalary { get; set; }
        public string createdDate { get; set; }
        public string joiningLetterDate { get; set; }
        public string idCardIssuanceDate { get; set; }
        public string healthCardIssuanceDate { get; set; }
        public string eobCardIssuanceDate { get; set; }
        public string probationPeriod { get; set; }
        public string idCardExpiryDate { get; set; }
        public string contractExpiryDate { get; set; }
        public string isInterestBased { get; set; }
        public string isZakatBased { get; set; }
        public string professionalTaxAmount { get; set; }
        public string eligibleForTaxInLastYear { get; set; }
        public string extendProbation { get; set; }

        /**
         Foreign Keys Definations
         */
        public int department_id { get; set; }
        public int sub_department_id { get; set; }
        public int shift_id { get; set; }
        public int employementType_id { get; set; }
        public int jobStatus_id { get; set; }
        public int designation_id { get; set; }
        public int operatingUnit_id { get; set; }
        public int head_id { get; set; }
        public int grade_id { get; set; }
        public int leavePlanType_id { get; set; }
        public int transferType_id { get; set; }

        /***
         * RelationShips
         **/
        [ForeignKey("department_id")]
        public virtual Department Department { get; set; }
        [ForeignKey("sub_department_id")]
        public virtual SubDepartment SubDepartment { get; set; }
        [ForeignKey("shift_id")]
        public virtual Shift Shift { get; set; }
        [ForeignKey("employementType_id")]
        public virtual EmploymentType EmploymentType { get; set; }
        [ForeignKey("jobStatus_id")]
        public virtual JobStatus JobStatus { get; set; }
        [ForeignKey("designation_id")]
        public virtual Designation Designation { get; set; }
        [ForeignKey("operatingUnit_id")]
        public virtual OperatingUnit OperatingUnit { get; set; }
        [ForeignKey("head_id")]
        public virtual HeadOffice HeadOffice { get; set; }
        [ForeignKey("grade_id")]
        public virtual Grade Grade { get; set; }
        [ForeignKey("leavePlanType_id")]
        public virtual LeavePlanType LeavePlanType { get; set; }
        [ForeignKey("transferType_id")]
        public virtual TransferType TransferType { get; set; }
    }
}