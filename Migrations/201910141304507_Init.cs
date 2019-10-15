namespace Depman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Long(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Long(nullable: false, identity: true),
                        EmployeeFirstName = c.String(),
                        EmployeeLastName = c.String(),
                        Degree = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        EmployeeImg = c.Byte(),
                        Rating = c.Single(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HireDate = c.DateTime(nullable: false),
                        DepartmentFK = c.Long(nullable: false),
                        EmployeeFK = c.Long(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Departments", t => t.DepartmentFK, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeFK)
                .Index(t => t.DepartmentFK)
                .Index(t => t.EmployeeFK);
            
            CreateTable(
                "dbo.ProjectDetails",
                c => new
                    {
                        ProjectDetailID = c.Long(nullable: false, identity: true),
                        ProjectDescription = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        DepartmentFK = c.Long(),
                        ProjectFK = c.Long(),
                    })
                .PrimaryKey(t => t.ProjectDetailID)
                .ForeignKey("dbo.Departments", t => t.DepartmentFK)
                .ForeignKey("dbo.Projects", t => t.ProjectFK)
                .Index(t => t.DepartmentFK)
                .Index(t => t.ProjectFK);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Long(nullable: false, identity: true),
                        ProjectTitle = c.String(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportID = c.Long(nullable: false, identity: true),
                        ReportDescription = c.String(),
                        Rating = c.Single(nullable: false),
                        EmployeeFK = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID)
                .ForeignKey("dbo.Employees", t => t.EmployeeFK, cascadeDelete: true)
                .Index(t => t.EmployeeFK);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionID = c.Long(nullable: false, identity: true),
                        QuestionTitle = c.String(),
                        Rating = c.Single(),
                        ProjectFK = c.Long(),
                        Report_ReportID = c.Long(),
                    })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.Projects", t => t.ProjectFK)
                .ForeignKey("dbo.Reports", t => t.Report_ReportID)
                .Index(t => t.ProjectFK)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Long(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Authorization = c.Int(nullable: false),
                        EmployeeFK = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Employees", t => t.EmployeeFK, cascadeDelete: true)
                .Index(t => t.EmployeeFK);
            
            CreateTable(
                "dbo.ProjectDetailEmployees",
                c => new
                    {
                        ProjectDetail_ProjectDetailID = c.Long(nullable: false),
                        Employee_EmployeeID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectDetail_ProjectDetailID, t.Employee_EmployeeID })
                .ForeignKey("dbo.ProjectDetails", t => t.ProjectDetail_ProjectDetailID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID, cascadeDelete: true)
                .Index(t => t.ProjectDetail_ProjectDetailID)
                .Index(t => t.Employee_EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "EmployeeFK", "dbo.Employees");
            DropForeignKey("dbo.Questions", "Report_ReportID", "dbo.Reports");
            DropForeignKey("dbo.Questions", "ProjectFK", "dbo.Projects");
            DropForeignKey("dbo.Reports", "EmployeeFK", "dbo.Employees");
            DropForeignKey("dbo.ProjectDetails", "ProjectFK", "dbo.Projects");
            DropForeignKey("dbo.ProjectDetailEmployees", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.ProjectDetailEmployees", "ProjectDetail_ProjectDetailID", "dbo.ProjectDetails");
            DropForeignKey("dbo.ProjectDetails", "DepartmentFK", "dbo.Departments");
            DropForeignKey("dbo.Employees", "EmployeeFK", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentFK", "dbo.Departments");
            DropIndex("dbo.ProjectDetailEmployees", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.ProjectDetailEmployees", new[] { "ProjectDetail_ProjectDetailID" });
            DropIndex("dbo.Users", new[] { "EmployeeFK" });
            DropIndex("dbo.Questions", new[] { "Report_ReportID" });
            DropIndex("dbo.Questions", new[] { "ProjectFK" });
            DropIndex("dbo.Reports", new[] { "EmployeeFK" });
            DropIndex("dbo.ProjectDetails", new[] { "ProjectFK" });
            DropIndex("dbo.ProjectDetails", new[] { "DepartmentFK" });
            DropIndex("dbo.Employees", new[] { "EmployeeFK" });
            DropIndex("dbo.Employees", new[] { "DepartmentFK" });
            DropTable("dbo.ProjectDetailEmployees");
            DropTable("dbo.Users");
            DropTable("dbo.Questions");
            DropTable("dbo.Reports");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectDetails");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
