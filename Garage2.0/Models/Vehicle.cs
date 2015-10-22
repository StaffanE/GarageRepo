using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models
{
    public enum VehicleEnum { Bil, Båt, MC, Flygplan, Trampcykel}
    public class Vehicle
    {
        private DateTime _date = DateTime.Now;
        public int Id { get; set; }
        [Display(Name = "Fordonstyp")]
        public VehicleEnum VehicleType  { get; set; }
        [Display(Name = "Reg. nummer")]
        public string RegNumber { get; set; }
        [Display(Name = "Färg")]
        public string Color { get; set; }
        [Display(Name = "Fabrikat")]
        public string Brand { get; set; }
        [Display(Name = "Modell")]
        public string Make { get; set; }
        [Display(Name = "Antal hjul")]
        public int NumberOfWheels { get; set; }
        [Display(Name = "Parkerad (ankomsttid)")]
        public DateTime ArrivalTime {get { return _date; }
                                     set { _date = value; }}
    }
    public class ThisMoment
    {
        DateTime parkedAtTime = DateTime.Now;
    }
} 