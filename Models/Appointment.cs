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
        public decimal totalCost { get; set; }

        public int technicianID { get; set; }
        public virtual Technician technicians { get; set; }



        public int automobileID { get; set; }
        public virtual Automobile Automobileinfo { get; set; }

    }
}