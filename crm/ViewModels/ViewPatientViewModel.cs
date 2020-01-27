using crm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.ViewModels
{
    public class ViewPatientViewModel
    {
        public Patient Patient { get; set; }
        public IList<PatientAllergy> Allergies { get; set; }
        public IList<Doctor> Doctors { get; set; }
        //public Doctor Doctor { get; set; }
        //public IList<Test> Tests { get; set; }
        //public IList<Appointment> Appointments { get; set; }
        //public IList<Prescription> Prescriptions { get; set; }

        public ViewPatientViewModel()
        {

        }

        public ViewPatientViewModel(Patient patient, List<Doctor> doctors, List<PatientAllergy> allergies)
        {
            this.Patient = patient;
            this.Allergies = allergies;
            this.Doctors = doctors;
        }

    }
}
