namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        PasswordHash = c.String(nullable: false),
                        PasswordSalt = c.String(nullable: false),
                        FirstLogin = c.Boolean(nullable: false),
                        UserId = c.Int(),
                        RecoverPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Association",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FacilityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facility", t => t.FacilityId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.FacilityId);
            
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
                "dbo.Resources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        CategoryId = c.String(nullable: false, maxLength: 100),
                        SubCategoryId = c.String(maxLength: 100),
                        FacilityId = c.Int(nullable: false),
                        Description = c.String(maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        Quantity = c.Int(nullable: false),
                        OldQuantity = c.Int(),
                        Comments = c.String(),
                        FacilityName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facility", t => t.FacilityId, cascadeDelete: true)
                .Index(t => t.FacilityId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                        UserEnabled = c.Boolean(nullable: false),
                        FacilityName = c.String(),
                        RoleName = c.String(),
                        Facility_Id = c.Int(),
                        Facility_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Facility", t => t.Facility_Id)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Facility", t => t.Facility_Id1)
                .Index(t => t.RoleId)
                .Index(t => t.Facility_Id)
                .Index(t => t.Facility_Id1);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Association", "UserId", "dbo.Users");
            DropForeignKey("dbo.Association", "FacilityId", "dbo.Facility");
            DropForeignKey("dbo.Facility", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Facility_Id1", "dbo.Facility");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Users", "Facility_Id", "dbo.Facility");
            DropForeignKey("dbo.Resources", "FacilityId", "dbo.Facility");
            DropIndex("dbo.Users", new[] { "Facility_Id1" });
            DropIndex("dbo.Users", new[] { "Facility_Id" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Resources", new[] { "FacilityId" });
            DropIndex("dbo.Facility", new[] { "Users_Id" });
            DropIndex("dbo.Association", new[] { "FacilityId" });
            DropIndex("dbo.Association", new[] { "UserId" });
            DropTable("dbo.ErrorLog");
            DropTable("dbo.Role");
            DropTable("dbo.Users");
            DropTable("dbo.Resources");
            DropTable("dbo.Facility");
            DropTable("dbo.Association");
            DropTable("dbo.Account");
        }
    }
}
