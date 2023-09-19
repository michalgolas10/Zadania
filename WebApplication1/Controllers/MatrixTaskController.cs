using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZadaniaRekrutacyjne.Models;
using ZadaniaRekrutacyjneBLL.Interfaces;

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
        public ActionResult FindHole(MatrixTaskViewModel matrixInString)
        {
            var matrixOfIntiger = _findHoleService.CreateMatrixFromString(matrixInString.MatrixString);
            var holes = _findHoleService.FindHole(matrixOfIntiger);
            ViewBag.Model = holes;
            return View();
        }
    }
}
