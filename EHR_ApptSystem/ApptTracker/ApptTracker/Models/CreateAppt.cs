using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApptTracker.Models
{
    public class CreateAppt
    {
        public int ID { get; set; }

        public Patient patient { get; set; }
        public Provider provider { get; set; }

        [Display(Name = "Patient First Name")]
        public string firstname { get; set; }

        [Display(Name = "Patient Last Name")]
        public string lastname { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select a date")]
        public string apptdate { get; set; }

        [Display(Name = "Time")]
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Please select a time")]
        public string appttime { get; set; }

        [Display(Name = "Appointment Length")]
        public string apptlength { get; set; }

        [Display(Name = "Reason")]
        [DataType(DataType.MultilineText)]
        [MaxLength(300, ErrorMessage = "Description too long")]
        public string reason { get; set; }
    }
}
