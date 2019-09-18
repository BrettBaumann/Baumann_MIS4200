using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baumann_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public string description { get; set; }
        public DateTime dateServiced { get; set; }
        public decimal totalCost { get; set; }        public ICollection<Technician> TechnicianDetail { get; set; }
    }
}