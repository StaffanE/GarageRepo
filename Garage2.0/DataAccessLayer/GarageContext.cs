using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Garage2._0.DataAccessLayer
{
    public class GarageContext : DbContext                            // Skapar kopplingen till databasen
    {
        public GarageContext() : base("VehicleDatabase")            // Namnger databasen
        {

        }

        public DbSet<Models.Vehicle> Vehicles { get; set; }                    //  Gör en "abstrakt" lista av Vehicles, alltså själva tabellen, kan man säga.
        public DbSet<Models.Member> Members { get; set; }
        public DbSet<Models.VehicleType> VehicleTypes { get; set; }
    }
}