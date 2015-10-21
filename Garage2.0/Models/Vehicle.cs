using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public enum VehicleEnum { Bil, Båt, MC, Flygplan, Trampcykel}

    public class Vehicle
    {
        public int Id { get; set; }
        public VehicleEnum VehicleType { get; set; }
        public string RegNumber { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public DateTime ArrivalTime { get; set; }


    }
} 