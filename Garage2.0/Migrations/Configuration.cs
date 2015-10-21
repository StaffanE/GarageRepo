namespace Garage2._0.Migrations
{
    using Garage2._0.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._0.DataAccessLayer.GarageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2._0.DataAccessLayer.GarageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Vehicles.AddOrUpdate(
              v => v.RegNumber,
              new Vehicle { VehicleType = VehicleEnum.Bil, RegNumber = "SCD918", Color = "Blå", Brand = "Volvo", Make = "V70", NumberOfWheels = 4, ArrivalTime = DateTime.Now },
              new Vehicle { VehicleType = VehicleEnum.Båt, RegNumber = "DFC234", Color = "Grön", Brand = "Linjett", Make = "33", NumberOfWheels = 0, ArrivalTime = DateTime.Now },
              new Vehicle { VehicleType = VehicleEnum.MC, RegNumber = "KFL423", Color = "Svart", Brand = "Yamaha", Make = "T87", NumberOfWheels = 2, ArrivalTime = DateTime.Now },
              new Vehicle { VehicleType = VehicleEnum.Bil, RegNumber = "FGH234", Color = "Röd", Brand = "Ferrari", Make = "Testarossa", NumberOfWheels = 4, ArrivalTime = DateTime.Now },
              new Vehicle { VehicleType = VehicleEnum.Trampcykel, RegNumber = "GFD234", Color = "Vit", Brand = "Crescent", Make = "Blixten", NumberOfWheels = 2, ArrivalTime = DateTime.Now },
              new Vehicle { VehicleType = VehicleEnum.Flygplan, RegNumber = "DFR342", Color = "Randig", Brand = "Saab", Make = "JAS 39 Gripen", NumberOfWheels = 3, ArrivalTime = DateTime.Now }


            );

        }
    }
}
