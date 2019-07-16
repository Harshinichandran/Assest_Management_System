namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DD8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facility", "UsersId", c => c.String());
            AddColumn("dbo.Facility", "Users_Id", c => c.Int());
            AlterColumn("dbo.Users", "Address", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "SelectedFacility", c => c.String(nullable: false));
            CreateIndex("dbo.Facility", "Users_Id");
            AddForeignKey("dbo.Facility", "Users_Id", "dbo.Users", "Id");
            DropColumn("dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Facility", "Users_Id", "dbo.Users");
            DropIndex("dbo.Facility", new[] { "Users_Id" });
            AlterColumn("dbo.Users", "SelectedFacility", c => c.String());
            AlterColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Users", "Address", c => c.String(nullable: false));
            DropColumn("dbo.Facility", "Users_Id");
            DropColumn("dbo.Facility", "UsersId");
        }
    }
}
