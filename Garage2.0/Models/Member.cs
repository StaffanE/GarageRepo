using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models
{
    public class Member
    {
        public int Id { get; set; }
        
        [Display(Name = "Förnamn")]
        [Required]
        [StringLength(32)]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        [Required]
        [StringLength(32)]
        public string LastName { get; set; }

        [Display(Name = "Ägare / Medlem")]
        public string FullName 
        { 
            get{
                var fullName = FirstName + " " + LastName;
                fullName.Trim();
                return fullName;
             }  
        }

        [Display(Name = "Personnummer")]
        [Required]
        [StringLength(10)]
        public string PersonalNumber { get; set; }

        [Display(Name = "Telefon")]
        [Required]
        [StringLength(10)]
        public string PhoneNo { get; set; }

        [Display(Name = "Adress")]
        [StringLength(32)]
        public string Adress { get; set; }

        [Display(Name = "Postnummer")]
        [StringLength(32)]
        public string Zipcode { get; set; }

        [Display(Name = "Ort")]
        [StringLength(32)]
        public string City { get; set; }
    }
}