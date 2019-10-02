using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace baumann_MIS4200.Models
{
    public class Technician
    {
        public int technicianID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Work Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter your email associated with the company")]

        public string email { get; set; }

        [Display(Name = "Work phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]

        public string phone { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}