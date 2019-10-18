namespace Depman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSexRecordToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Sex", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Sex");
        }
    }
}
