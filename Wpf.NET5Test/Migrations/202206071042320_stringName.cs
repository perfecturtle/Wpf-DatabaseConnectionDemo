namespace Wpf.NET5Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Name", c => c.Int(nullable: false));
        }
    }
}
