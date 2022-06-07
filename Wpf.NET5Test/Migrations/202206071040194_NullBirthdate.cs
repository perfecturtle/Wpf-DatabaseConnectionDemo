namespace Wpf.NET5Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullBirthdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
