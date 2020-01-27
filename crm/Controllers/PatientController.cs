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
    }
}