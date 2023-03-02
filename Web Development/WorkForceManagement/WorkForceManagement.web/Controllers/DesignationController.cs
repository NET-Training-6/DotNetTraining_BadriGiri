using Microsoft.AspNetCore.Mvc;
using WorkForceManagement.web.Data;
using WorkForceManagement.web.Models;

namespace WorkForceManagement.web.Controllers
{
    public class DesignationController : Controller
    {
        WorkForceContext db=new WorkForceContext();
        public IActionResult Index()
        {
            List<Designation> designations = db.DesignationsTable.ToList();
            return View(designations);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Designation designation) 
        {
            db.DesignationsTable.Add(designation);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var designation = db.DesignationsTable.Find(id);
            
            return View(designation);
        }
        [HttpPost]
        public IActionResult Edit(Designation designation)
        {
            db.DesignationsTable.Update(designation);
           
            db.SaveChanges();           
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete (int id)
        {
            var designation= db.DesignationsTable.Find(id);
            return View(designation);
        }
        [HttpPost]
        public IActionResult Delete(Designation designation)
        {
            db.DesignationsTable.Remove(designation);
            db.SaveChanges(true);
            return RedirectToAction("Index");

        }
    }
}
