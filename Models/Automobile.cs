using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baumann_MIS4200.Models
{
    public class Automobile
    {

        public int automobileID { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public ICollection<Appointment> Appointments { get; set; }


    }
}