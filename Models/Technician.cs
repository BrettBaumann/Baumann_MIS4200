using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace baumann_MIS4200.Models
{
    public class Technician
    {
        public int technicianID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public ICollection<Appointment> appointments { get; set; }
    }
}