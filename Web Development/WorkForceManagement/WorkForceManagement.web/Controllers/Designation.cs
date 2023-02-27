using Microsoft.AspNetCore.Mvc;
using WorkForceManagement.web.Data;

namespace WorkForceManagement.web.Controllers
{
    public class Designation : Controller
    {
        WorkForceContext db=new WorkForceContext();
        public IActionResult Index()
        {

            return View();
        }
    }
}
