namespace Wpf.NET5Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPeopleRemoveIntake : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Profession = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
