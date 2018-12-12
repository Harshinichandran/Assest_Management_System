namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Harshini : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Account", "DateofBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Account", "DateofBirth", c => c.String(nullable: false));
            DropTable("dbo.Facility");
        }
    }
}
