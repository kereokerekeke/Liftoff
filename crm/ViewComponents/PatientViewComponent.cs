using crm.Data;
using crm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm.ViewComponents
{
    [ViewComponent(Name = "Patient")]
    public class PatientViewComponent : ViewComponent
    {

            private readonly crmDbContext db;

        public PatientViewComponent(crmDbContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var patient = await GetPatientByIdAsync(id);
            return View(patient);
        }

        private Task<Patient> GetPatientByIdAsync(int id)
        {
            return Task.FromResult(db.Patients.Include(x => x.PatientAllergies)
                                              .ThenInclude(x => x.Allergy)
                                              .Single(x => x.Id == id));
        }

    }
}
