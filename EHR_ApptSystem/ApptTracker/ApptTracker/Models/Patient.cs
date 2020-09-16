using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApptTracker.Models
{
    public class Patient
    {
        public int ID { get; set; }

        [Display(Name = "Patient First Name")]
        [Required(ErrorMessage = "Please enter a first name")]
        public string firstname { get; set; }

        [Display(Name = "Patient Last Name")]
        [Required(ErrorMessage = "Please enter a last name")]
        public string lastname { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select a date")]
        public string birthday { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "Please enter a valid phone number")]
        public string phone { get; set; }

        [Display(Name = "Street")]
        [Required(ErrorMessage = "Please enter a street address")]
        public string street { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter a city")]
        public string city { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please choose a state")]
        public string state { get; set; }

        [Display(Name = "Zipcode")]
        [Required(ErrorMessage = "Please enter a zipcode")]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string postalcode { get; set; }

        public ICollection<CreateAppt> appts { get; set; }
    }
}
