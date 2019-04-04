namespace AttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AttendanceSystem.Models.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "AttendanceSystem.Models.Database";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AttendanceSystem.Models.MyDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
