using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
