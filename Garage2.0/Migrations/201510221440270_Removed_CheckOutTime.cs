namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removed_CheckOutTime : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vehicles", "CheckOutTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "CheckOutTime", c => c.DateTime());
        }
    }
}
