using System.Diagnostics;
using GarageManagementSystem.Interfaces;
using GarageManagementSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GarageManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGarageService _garageService;


        public HomeController(ILogger<HomeController> logger, IGarageService garageService)
        {
            _logger = logger;
            _garageService = garageService;
        }

        public IActionResult Index()
        {
            ViewBag.GarageName = _garageService.GetGarageName();
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
