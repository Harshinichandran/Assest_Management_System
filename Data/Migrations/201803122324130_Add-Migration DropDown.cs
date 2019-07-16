namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationDropDown : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SelectedFacility", c => c.String());
            AlterColumn("dbo.Users", "Role", c => c.String());
            DropColumn("dbo.Users", "Facility");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Facility", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Role", c => c.String(nullable: false));
            DropColumn("dbo.Users", "SelectedFacility");
        }
    }
}
