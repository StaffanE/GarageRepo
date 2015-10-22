namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckOut : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "CheckOutTime", c => c.DateTime());
            DropColumn("dbo.Vehicles", "CeckOutTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "CeckOutTime", c => c.DateTime());
            DropColumn("dbo.Vehicles", "CheckOutTime");
        }
    }
}
