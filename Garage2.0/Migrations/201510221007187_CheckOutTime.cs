namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckOutTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "CeckOutTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "CeckOutTime");
        }
    }
}
