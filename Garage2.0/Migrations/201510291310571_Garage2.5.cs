namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage25 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 32),
                        LastName = c.String(nullable: false, maxLength: 32),
                        PersonalNumber = c.String(nullable: false, maxLength: 10),
                        PhoneNo = c.String(nullable: false, maxLength: 10),
                        Adress = c.String(maxLength: 32),
                        Zipcode = c.String(maxLength: 32),
                        City = c.String(maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfVehicle = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Vehicles", "MemberId", c => c.Int(nullable: false));
            AddColumn("dbo.Vehicles", "VehicleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "MemberId");
            CreateIndex("dbo.Vehicles", "VehicleTypeId");
            AddForeignKey("dbo.Vehicles", "MemberId", "dbo.Members", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Vehicles", "VehicleTypeId", "dbo.VehicleTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Vehicles", "VehicleType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "VehicleType", c => c.Int(nullable: false));
            DropForeignKey("dbo.Vehicles", "VehicleTypeId", "dbo.VehicleTypes");
            DropForeignKey("dbo.Vehicles", "MemberId", "dbo.Members");
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeId" });
            DropIndex("dbo.Vehicles", new[] { "MemberId" });
            DropColumn("dbo.Vehicles", "VehicleTypeId");
            DropColumn("dbo.Vehicles", "MemberId");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.Members");
        }
    }
}
