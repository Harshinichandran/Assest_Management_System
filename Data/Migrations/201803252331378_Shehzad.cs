namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shehzad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        PasswordHash = c.String(),
                        PasswordSalt = c.String(),
                        UName = c.String(),
                        Pswd = c.String(),
                        FirstLogin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ErrorLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppName = c.String(nullable: false),
                        Thread = c.String(nullable: false),
                        Level = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        Exception = c.String(nullable: false),
                        LogDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Facility",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Landmark = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 200),
                        RoleId = c.Int(nullable: false),
                        SelectedFacility = c.Int(nullable: false),
                        UserEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facility", t => t.SelectedFacility)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId)
                .Index(t => t.SelectedFacility);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CategoryId = c.String(),
                        SubCategoryId = c.String(),
                        FacilityId = c.String(),
                        Description = c.String(maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Users", "SelectedFacility", "dbo.Facility");
            DropForeignKey("dbo.Facility", "Users_Id", "dbo.Users");
            DropIndex("dbo.Users", new[] { "SelectedFacility" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Facility", new[] { "Users_Id" });
            DropTable("dbo.Resources");
            DropTable("dbo.Role");
            DropTable("dbo.Users");
            DropTable("dbo.Facility");
            DropTable("dbo.ErrorLog");
            DropTable("dbo.Account");
        }
    }
}
