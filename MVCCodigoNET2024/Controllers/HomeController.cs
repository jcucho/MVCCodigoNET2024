using Microsoft.AspNetCore.Mvc;
using MVCCodigoNET2024.Interfaces;
using MVCCodigoNET2024.Models;
using System.Diagnostics;

namespace MVCCodigoNET2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDatabase _database;

        public HomeController(ILogger<HomeController> logger, IDatabase database)
        {
            _logger = logger;
            _database = database;
        }

        public IActionResult Index()
        {
            _database.Create();
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
