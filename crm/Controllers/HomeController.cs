using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crm.Models;
using crm.Data;
using Microsoft.EntityFrameworkCore;

namespace crm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private crmDbContext dbContext;

        public HomeController(ILogger<HomeController> logger, crmDbContext crmDbContext)
        {
            _logger = logger;
            dbContext = crmDbContext;
        }


        public IActionResult Index(int id)  // id is DoctorId
        {

            var appointments = dbContext.Appointments.Include(x => x.Doctor)
                                                     .Include(x => x.Patient)
                                                     .Where(x => x.DoctorID == id)
                                                     .ToList();

            return View(appointments);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
