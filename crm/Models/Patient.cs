using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string BloodType { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int BMI { get; set; }
        public int BFPercentage { get; set; }
        public IList<Appointment> Appointments { get; set; }
        public IList<Prescription> Presciptions { get; set; }
        public IList<Test> Tests { get; set; }
        public IList<PatientAllergy> PatientAllergies { get; set; }
    }
}
