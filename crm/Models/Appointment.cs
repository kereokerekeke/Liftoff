using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public IList<Prescription> Prescriptions { get; set; }
        public IList<Test> Tests { get; set; }
        public string Note { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
