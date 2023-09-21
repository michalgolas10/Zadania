using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using ZadaniaRekrutacyjne.Models;
using ZadaniaRekrutacyjneBLL.Interfaces;
using ZadaniaRekrutacyjneBLL.Services;

namespace ZadaniaRekrutacyjne.Controllers
{
    public class MatrixTaskController : Controller
    {
        // GET: MatrixTaskController
        private readonly IFindHoleService _findHoleService;
        public MatrixTaskController(IFindHoleService findHoleService)
        {
            _findHoleService = findHoleService;
        }

        public ActionResult FindHole()
        {
                return View();
        }
        [HttpPost]
        public ActionResult FindHole(MatrixTaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                var holes = _findHoleService.FindHole(model.MatrixString);
                ViewBag.Model = holes;
                return View(model);
            }
            else
            {
                return View();
            }
        }
    }
}
