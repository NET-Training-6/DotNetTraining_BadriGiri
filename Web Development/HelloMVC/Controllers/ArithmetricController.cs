using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class ArithmetricController : Controller
    {
        public IActionResult Mtable(int num)
        {

            return View(num);
        }
        public IActionResult UserMtable(int from, int to) 
        {
            var x = (from, to);
           return View(x);
        }
    }
}

