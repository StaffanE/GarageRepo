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

            context.VehicleTypes.AddOrUpdate(
              t => t.TypeOfVehicle,
              new VehicleType { Id = 1, TypeOfVehicle = "Bil" },
              new VehicleType { Id = 2, TypeOfVehicle = "Moped" },
              new VehicleType { Id = 3, TypeOfVehicle = "Buss" },
              new VehicleType { Id = 4, TypeOfVehicle = "MC" }
            );


            context.Members.AddOrUpdate(
              m => m.PersonalNumber,
              new Member { Id = 1, FirstName = "Erik", LastName = "Gadd", PersonalNumber = "6908016634", PhoneNo = "070-555555", Adress = "Luntmakargatan 2", Zipcode = "11612", City = "Stockholm" },
              new Member { Id = 2, FirstName = "Jul", LastName = "Tomten", PersonalNumber = "6908016632", PhoneNo = "555-555555", Adress = "Tomtebogatan 3", Zipcode = "11614", City = "Nordpolen" },
              new Member { Id = 3, FirstName = "Anna", LastName = "Wallin", PersonalNumber = "8204126624", PhoneNo = "070-455555", Adress = "Lunchgatan 12", Zipcode = "11611", City = "Stockholm" },
              new Member { Id = 4, FirstName = "Mats", LastName = "Wilander", PersonalNumber = "6905016624", PhoneNo = "070-555655", Adress = "Luntmakargatan 1", Zipcode = "11612", City = "Stockholm" }

            );


            context.Vehicles.AddOrUpdate(
              v => v.RegNumber,
              new Vehicle { RegNumber = "SCD918", Color = "Blå", Brand = "Volvo", Make = "V70", NumberOfWheels = 4, MemberId = 1, VehicleTypeId = 1 },
              new Vehicle { RegNumber = "DFC234", Color = "Grön", Brand = "Linjett", Make = "33", NumberOfWheels = 0, MemberId = 2, VehicleTypeId = 2 },
              new Vehicle { RegNumber = "KFL423", Color = "Svart", Brand = "Yamaha", Make = "T87", NumberOfWheels = 2, MemberId = 3, VehicleTypeId = 3 },
              new Vehicle { RegNumber = "FGH234", Color = "Röd", Brand = "Ferrari", Make = "Testarossa", NumberOfWheels = 4, MemberId = 4, VehicleTypeId = 4 }

            );

        }
    }
}
