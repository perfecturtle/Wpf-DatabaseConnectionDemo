namespace Wpf.NET5Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AutoIncrementId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Profession", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Profession", c => c.String());
        }
    }
}
