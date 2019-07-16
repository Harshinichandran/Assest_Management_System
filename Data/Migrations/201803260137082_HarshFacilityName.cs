namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HarshFacilityName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FacilityName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "FacilityName");
        }
    }
}
