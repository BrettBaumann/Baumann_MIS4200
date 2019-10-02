using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace baumann_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }

        [Display (Name ="Maintenance Completed")]
        [Required (ErrorMessage ="Description of Maintenance is required")]
        [StringLength(50)]
        public string description { get; set; }

        [Display(Name = "Date Serviced")]
        [Required(ErrorMessage = "Date of service is required")]
        [DataType(DataType.Date)]
        public DateTime dateServiced { get; set; }

        [Display(Name = "Total Cost")]
        [Required(ErrorMessage = "Total cost is required")]
        [DataType(DataType.Currency)]

        public decimal totalCost { get; set; }

        [Display(Name = "Technician Name")]
        public int technicianID { get; set; }
        public virtual Technician technicians { get; set; }


        [Display(Name = "Make and Model")]
        public int automobileID { get; set; }
        public virtual Automobile Automobileinfo { get; set; }

    }
}