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
            return View();
        }
    }
}
