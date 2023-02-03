using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class studentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            int[] numbers = { 12, 121, 423, 14, 21, 6 };
            return View(numbers);
        }
        public IActionResult Action()
        {
            return View();
        }
    }
}
