namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullified_CheckOutTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "CeckOutTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "CeckOutTime", c => c.DateTime(nullable: false));
        }
    }
}
