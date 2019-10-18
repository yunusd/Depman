namespace Depman.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeASNullableFinishDateRecord : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProjectDetails", "FinishDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProjectDetails", "FinishDate", c => c.DateTime(nullable: false));
        }
    }
}
