using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GarageManagementSystem.Interfaces;
using GarageManagementSystem.ViewModels;
using GarageManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace GarageManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGarageService _garageService;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, IGarageService garageService, AppDbContext context)
        {
            _logger = logger;
            _garageService = garageService;
            _context = context;
        }

        public IActionResult Index()
        { 
            int totalCars = _context.Cars.Count();
            int carsReady = _context.Cars.Count(c => c.IsReady);
            int carsInProgress = _context.Cars.Count(c => !c.IsReady);
            int totalOwners = _context.Owners.Count();
            int totalEmployees = _context.Employees.Count();

            var recentCars = _context.Cars
                .Include(c => c.Owner)
                .OrderByDescending(c => c.ArrivalDate)
                .Take(5)
                .ToList();

            ViewBag.TotalCars = totalCars;
            ViewBag.CarsReady = carsReady;
            ViewBag.CarsInProgress = carsInProgress;
            ViewBag.TotalOwners = totalOwners;
            ViewBag.TotalEmployees = totalEmployees;
            ViewBag.RecentCars = recentCars;

            return View();
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