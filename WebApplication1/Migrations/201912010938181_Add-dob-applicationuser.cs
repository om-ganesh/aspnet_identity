namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adddobapplicationuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "DateOfBirth", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.User", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "CreatedDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.User", "DateOfBirth");
        }
    }
}
