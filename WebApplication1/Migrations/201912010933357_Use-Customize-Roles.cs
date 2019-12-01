namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UseCustomizeRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Role", "CreatedBy", c => c.String());
            AddColumn("dbo.Role", "CreatedDate", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.Role", "Description", c => c.String());
            AddColumn("dbo.Role", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Role", "Discriminator");
            DropColumn("dbo.Role", "Description");
            DropColumn("dbo.Role", "CreatedDate");
            DropColumn("dbo.Role", "CreatedBy");
        }
    }
}
