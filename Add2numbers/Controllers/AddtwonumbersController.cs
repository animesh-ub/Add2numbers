using Add2numbers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Add2numbers.Controllers
{
    public class AddtwonumbersController : Controller
    {
        public class Add2NumController : Controller
        {
            [HttpGet]
            public IActionResult Index()
            {
                Numbers number = new Numbers();
                return View(number);
            }
            [HttpPost]
            public IActionResult Index(Numbers numbers)
            {
                ViewBag.res = numbers.Num1 + numbers.Num2;
                return View();
            }
        }
    }
}
