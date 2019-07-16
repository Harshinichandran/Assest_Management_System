namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DD11 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Facility", new[] { "Users_Id" });
            AlterColumn("dbo.Facility", "Users_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Facility", "Users_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Facility", new[] { "Users_Id" });
            AlterColumn("dbo.Facility", "Users_Id", c => c.Int());
            CreateIndex("dbo.Facility", "Users_Id");
        }
    }
}
