using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace baumann_MIS4200.Models
{
    public class Automobile
    {

        public int automobileID { get; set; }

        [Display(Name = "Make")]
        [Required(ErrorMessage = "Vehicle make is required")]
        [StringLength(20)]
        public string make { get; set; }

        [Display(Name = "Model")]
        [Required(ErrorMessage = "Vehicle model is required")]
        [StringLength(20)]
        public string model { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "Manufactured year is required")]
        [MinLength(4)]
        [MaxLength(4)]



        public string year { get; set; }

        public ICollection<Appointment> Appointments { get; set; }


    }
}