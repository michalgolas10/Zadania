using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using WebApplication1.Models;
using ZadaniaRekrutacyjne.Models;
using ZadaniaRekrutacyjneBLL.Interfaces;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMissingNumberService _missingNumberService;
        private readonly IFindHoleService _findHoleService;

        public HomeController(ILogger<HomeController> logger,IMissingNumberService missingNumberService, IFindHoleService findHoleService)
        {
            _missingNumberService = missingNumberService;
            _logger = logger;
            _findHoleService = findHoleService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MissingNumberViewModel model)
        {
            var s = _missingNumberService.FindMissingNumber(model.MissingNumber);
            ViewBag.Model = s;
            return View();
        }
        public IActionResult FindHole()
        {
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