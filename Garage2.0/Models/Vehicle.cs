using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models
{

    public class Vehicle
    {
        private DateTime _date = DateTime.Now;

        public int Id { get; set; }

        [Display(Name = "Reg. nummer")]
        [Required]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Fältet måste innehålla 6 tecken.")]
        [RegularExpression(@"^[\S]*$",  ErrorMessage = "Fältet får ej innehålla mellanslag.")]
        //[RegularExpression("^[-_,A-Za-z0-9]$", ErrorMessage = "Fältet får ej innehålla otillåtna tecken.")]
        public string RegNumber { get; set; }

        [Display(Name = "Färg")]
        [Required]
        [StringLength(16)]
        public string Color { get; set; }


        [Display(Name = "Fabrikat")]
        [Required]
        [StringLength(16)]
        public string Brand { get; set; }

        [Display(Name = "Modell")]
        [Required]
        [StringLength(32)]
        public string Make { get; set; }

        [Display(Name = "Antal hjul")]
        [Range(0,12)]
        public int NumberOfWheels { get; set; }

        [Display(Name = "Parkerad (ankomsttid)")]
        public DateTime ArrivalTime {get { return _date; }
                                     set { _date = value; }}
        [Required(ErrorMessage = "Ägare / Medlem krävs.")]
        public int MemberId { get; set; }                         // Foreign keys

        [Required(ErrorMessage = "Fordonstyp krävs.")]
        public int VehicleTypeId { get; set; }


        public virtual Member Member { get; set; }                // Navigation properties

        [Display(Name = "Fordonstyp")]                           //  Det verkar vara denna som styr displaNameFor i Viewen, ine den i VehicleType-modellen
        public virtual VehicleType VehicleType { get; set; }


      }
     
    }
