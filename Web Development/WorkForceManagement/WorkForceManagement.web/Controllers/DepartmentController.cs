using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorkForceManagement.web.Data;
using WorkForceManagement.web.Models;

namespace WorkForceManagement.web.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        WorkForceContext db = new WorkForceContext();
        [HttpGet]
        public IActionResult Index()
        {
            List<Department> departments = db.Departments.ToList();

            return View(departments);
        }
        [HttpGet]
        public IActionResult Add()
        {     
            return View();
        }
        [HttpPost]
        public IActionResult Add(Department department)
        {
            if(department is null && !ModelState.IsValid)
                    return Problem("to be inserted department object is null");

            db.Departments.Add(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
           var department =db.Departments.Find(id);
            return View(department);
        }
        [HttpPost]
        public IActionResult Edit(Department department)  
        {
            db.Departments.Update(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var department =db.Departments.Find(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Delete(Department department) 
        {
            db.Departments.Remove(department);
            db.SaveChanges();
           
            return RedirectToAction("Index");
        }
    }
}
