using Microsoft.AspNetCore.Mvc;
using PharmacyWarehouseV2.Models;
using System.Diagnostics;

namespace PharmacyWarehouseV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<PharmEmployee> employees;

            using (var dbContext = new PharmacyDBContext())
            {
                employees = dbContext.PharmEmployees.OrderBy(l => l.EmployeeLastName).ThenBy(f => f.EmployeeFirstName);
                return View(employees.ToList());
            }
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