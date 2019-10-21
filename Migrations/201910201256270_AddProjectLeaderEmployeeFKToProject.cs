namespace Depman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectLeaderEmployeeFKToProject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "ProjectLeaderEmployeeFK", c => c.Long());
            CreateIndex("dbo.Projects", "ProjectLeaderEmployeeFK");
            AddForeignKey("dbo.Projects", "ProjectLeaderEmployeeFK", "dbo.Employees", "EmployeeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ProjectLeaderEmployeeFK", "dbo.Employees");
            DropIndex("dbo.Projects", new[] { "ProjectLeaderEmployeeFK" });
            DropColumn("dbo.Projects", "ProjectLeaderEmployeeFK");
        }
    }
}
