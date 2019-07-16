namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HarshDD : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Facility", "Users_Id", "dbo.Users");
            DropIndex("dbo.Facility", new[] { "Users_Id" });
            DropColumn("dbo.Facility", "Users_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Facility", "Users_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Facility", "Users_Id");
            AddForeignKey("dbo.Facility", "Users_Id", "dbo.Users", "Id");
        }
    }
}
