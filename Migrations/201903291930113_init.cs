namespace AttendanceSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        operatingUnit_id = c.Int(),
                        LegalEntity_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.OperatingUnits", t => t.operatingUnit_id)
                .ForeignKey("dbo.LegalEntities", t => t.LegalEntity_id)
                .Index(t => t.operatingUnit_id)
                .Index(t => t.LegalEntity_id);
            
            CreateTable(
                "dbo.OperatingUnits",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SubDepartments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        department_id = c.Int(),
                        shift_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.department_id)
                .ForeignKey("dbo.Shifts", t => t.shift_id)
                .Index(t => t.department_id)
                .Index(t => t.shift_id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        start_time = c.String(),
                        end_time = c.String(),
                        check_in_time = c.String(),
                        check_out_time = c.String(),
                        early_min = c.String(),
                        late_min = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        gender = c.String(),
                        dob = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        address = c.String(),
                        city = c.String(),
                        country = c.String(),
                        image = c.String(),
                        phone = c.String(),
                        emergencyPhone = c.String(),
                        cnic = c.String(),
                        detail = c.String(),
                        religion = c.String(),
                        dislabled = c.Boolean(nullable: false),
                        bloodGroup = c.String(),
                        bankAcc = c.String(),
                        experience = c.String(),
                        department_id = c.Int(),
                        shift_id = c.Int(),
                        subDepartment_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.department_id)
                .ForeignKey("dbo.Shifts", t => t.shift_id)
                .ForeignKey("dbo.SubDepartments", t => t.subDepartment_id)
                .Index(t => t.department_id)
                .Index(t => t.shift_id)
                .Index(t => t.subDepartment_id);
            
            CreateTable(
                "dbo.LegalEntities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "LegalEntity_id", "dbo.LegalEntities");
            DropForeignKey("dbo.Employees", "subDepartment_id", "dbo.SubDepartments");
            DropForeignKey("dbo.Employees", "shift_id", "dbo.Shifts");
            DropForeignKey("dbo.Employees", "department_id", "dbo.Departments");
            DropForeignKey("dbo.SubDepartments", "shift_id", "dbo.Shifts");
            DropForeignKey("dbo.SubDepartments", "department_id", "dbo.Departments");
            DropForeignKey("dbo.Departments", "operatingUnit_id", "dbo.OperatingUnits");
            DropIndex("dbo.Employees", new[] { "subDepartment_id" });
            DropIndex("dbo.Employees", new[] { "shift_id" });
            DropIndex("dbo.Employees", new[] { "department_id" });
            DropIndex("dbo.SubDepartments", new[] { "shift_id" });
            DropIndex("dbo.SubDepartments", new[] { "department_id" });
            DropIndex("dbo.Departments", new[] { "LegalEntity_id" });
            DropIndex("dbo.Departments", new[] { "operatingUnit_id" });
            DropTable("dbo.LegalEntities");
            DropTable("dbo.Employees");
            DropTable("dbo.Shifts");
            DropTable("dbo.SubDepartments");
            DropTable("dbo.OperatingUnits");
            DropTable("dbo.Departments");
        }
    }
}
