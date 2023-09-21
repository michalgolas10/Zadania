using Microsoft.AspNetCore.Mvc;
using ZadaniaRekrutacyjne.Models;
using ZadaniaRekrutacyjneBLL.Interfaces;
using ZadaniaRekrutacyjneBLL.Services;

namespace ZadaniaRekrutacyjne.Controllers
{
    public class FindTheSmallestPostivieIntigerController : Controller
    {
        private readonly IFindPositiveInt _findPositiveInt;
        public FindTheSmallestPostivieIntigerController(IFindPositiveInt findPositiveInt)
        {
               _findPositiveInt= findPositiveInt;
        }
        public IActionResult FindThePositiveInt()
        {
                return View();
        }
        [HttpPost]
        public IActionResult FindThePositiveInt(FindPositiveIngViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _findPositiveInt.FindPositiveIntiger(model.numbersToCheck);
                ViewBag.Model = result;
                return View(model);
            }
            else
            {
                return View();
            }
            
        }
    }
}
