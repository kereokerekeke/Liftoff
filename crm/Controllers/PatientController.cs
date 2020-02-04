using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crm.Data;
using crm.Models;
using crm.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crm.Controllers
{
    public class PatientController : Controller
    {
        private crmDbContext dbContext;

        public PatientController(crmDbContext crmDbContext)
        {
            dbContext = crmDbContext;
        }

        public IActionResult Index(int id)
        {
            var patient = dbContext.Patients
                                        .Include(x => x.Appointments)
                                        .Include(x => x.Tests)
                                        .Include(x => x.Presciptions)
                                        .Single(x => x.Id == id);

            List<Doctor> doctors = dbContext.Doctors.ToList();

            List<PatientAllergy> allergies = dbContext.PatientAllergies
                                            .Include(allergy => allergy.Allergy)
                                            .Where(pa => pa.PatientId == id)
                                            .ToList();

            ViewPatientViewModel viewPatientViewModel = new ViewPatientViewModel(patient, doctors, allergies);

            return View(viewPatientViewModel);
        }

        public IActionResult Add()
        {
            AddPatientViewModel addPatientViewModel = new AddPatientViewModel();

            return View(addPatientViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddPatientViewModel addPatientViewModel)
        {
            Patient newPatient = new Patient
            {
                FirstName = addPatientViewModel.FirstName,
                LastName = addPatientViewModel.LastName,
                Age = addPatientViewModel.Age,
                Gender = addPatientViewModel.Gender,
                MaritalStatus = addPatientViewModel.MaritalStatus,
                BloodType = addPatientViewModel.BloodType,
                Height = addPatientViewModel.Height,
                Weight = addPatientViewModel.Weight,
                BMI = addPatientViewModel.BMI,
                BFPercentage = addPatientViewModel.BFPercentage
            };

            dbContext.Patients.Add(newPatient);

            dbContext.SaveChanges();

            return Redirect($"/Patient?id={newPatient.Id}");
        }

    }
}