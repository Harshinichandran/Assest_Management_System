namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DD6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "FacilityPeru_Id", c => c.Int());
            CreateIndex("dbo.Users", "FacilityPeru_Id");
            AddForeignKey("dbo.Users", "FacilityPeru_Id", "dbo.Facility", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "FacilityPeru_Id", "dbo.Facility");
            DropIndex("dbo.Users", new[] { "FacilityPeru_Id" });
            DropColumn("dbo.Users", "FacilityPeru_Id");
            DropColumn("dbo.Users", "UserId");
        }
    }
}
