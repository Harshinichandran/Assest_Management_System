namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Harshini : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Account", "DateofBirth", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Account", "DateofBirth");
        }
    }
}
