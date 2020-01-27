using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crm.Data;
using Microsoft.AspNetCore.Mvc;

namespace crm.Controllers
{
    public class AppointmentController : Controller
    {

        private crmDbContext dbContext;

        public AppointmentController(crmDbContext crmDbContext)
        {
            dbContext = crmDbContext;
        }

        public IActionResult Index(int id)
        {


            return View(id);
        }
    }
}