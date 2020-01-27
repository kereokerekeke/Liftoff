using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Speciality { get; set; }
        public IList<Appointment> Appointments { get; set; }
    }
}
