namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VehiclesValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "RegNumber", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Vehicles", "Color", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.Vehicles", "Brand", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.Vehicles", "Make", c => c.String(nullable: false, maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Make", c => c.String());
            AlterColumn("dbo.Vehicles", "Brand", c => c.String());
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
            AlterColumn("dbo.Vehicles", "RegNumber", c => c.String());
        }
    }
}
