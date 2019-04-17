using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceSystem.Models
{
    public class LeavePlanType
    {
        public int id { get; set; }
        public int CasualLeave { get; set; }
        public int SickLeave { get; set; }
        public int AnnualLeave { get; set; }
        public int MaternityLeave { get; set; }
        public int LeaveWOPay { get; set; }
    }
}