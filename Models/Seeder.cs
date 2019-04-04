using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace AttendanceSystem.Models
{
    public class Seeder : DropCreateDatabaseIfModelChanges<Models.MyDatabase>
    {
        protected override void Seed(MyDatabase context)
        {
            
            base.Seed(context);
        }
    }
}