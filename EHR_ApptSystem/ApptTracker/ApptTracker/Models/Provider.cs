using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApptTracker.Models
{
    public class Provider
    {
        public int ID { get; set; }

        [Display(Name = "Provider First Name")]
        [Required(ErrorMessage = "Please enter a first name")]
        public string firstname { get; set; }

        [Display(Name = "Provider Last Name")]
        [Required(ErrorMessage = "Please enter a last name")]
        public string lastname { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter a valid phone number")]
        public int phone { get; set; }

        [Display(Name = "Specialty")]
        [Required(ErrorMessage = "Please select a specialty")]
        public string specialty { get; set; }

        public ICollection<CreateAppt> appts { get; set; }
    }
}
