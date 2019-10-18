namespace Depman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEmployeeImgTypeToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeImgPath", c => c.String());
            AlterColumn("dbo.Employees", "Phone", c => c.String(maxLength: 11));
            DropColumn("dbo.Employees", "EmployeeImg");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeeImg", c => c.Byte());
            AlterColumn("dbo.Employees", "Phone", c => c.String());
            DropColumn("dbo.Employees", "EmployeeImgPath");
        }
    }
}
