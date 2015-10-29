using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Garage2._0.Models
{
    public class VehicleType
    {
        public int Id { get; set; }

        [Display(Name = "Fordonstyp")]
        [Required]
        [StringLength(32)]
        public string TypeOfVehicle { get; set; }
    }
}