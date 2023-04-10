using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;
using WorkForceManagement.web.Data;
using WorkForceManagement.web.Helpers;
using WorkForceManagement.web.Mapper;
using WorkForceManagement.web.Models;
using WorkForceManagement.web.ViewModels;

namespace WorkForceManagement.web.Controllers
{
    public class EmployeeController : Controller
    {

        WorkForceContext db = new WorkForceContext();

        [HttpGet]
        public IActionResult Index()
        {
            List<Employee> employees = db.Employees.ToList();
            List<EmployeeViewModel> employeesViewModels = employees.MapToViewModel();
            return View(employeesViewModels);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var employee=db.Employees.Find(id);
            var employeeViewModel = employee.MapToViewModel();
            return View(employeeViewModel);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            //DropDown Of Department
            var departments=db.Departments.ToList();
            var depsSelectList = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.ID.ToString() }).ToList();
            depsSelectList.Add(new SelectListItem { Text = "--Select Department--", Selected = true });
            ViewData["Deps"] = depsSelectList;

            //var designations=db.DesignationsTable.ToList();
            //var desSelectList = designations.Select(y => new SelectListItem { Text = y.Title, Value = y.PayRange });            
            //ViewData["Des"]=desSelectList;


            return View();
            

        }

        [HttpPost]
        public IActionResult Add(EmployeeViewModel employeeViewModel)
        {
            var relativePath = ProfileImageHelper.SaveImage(employeeViewModel.ProfileImage);
            var employee = employeeViewModel.MapToModel();

            employee.ProfileImagePath = relativePath;
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Delet(int id)
        {
            var employee = db.Employees.Find(id);
            var employeeViewModel = employee.MapToViewModel();
            return View(employeeViewModel);
        }

        [HttpPost]
        public IActionResult Delet(EmployeeViewModel employeeViewModel)
        {
            var employee = employeeViewModel.MapToModel();
            db.Employees.Remove(employee);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
           var employee= db.Employees.Find(id).MapToViewModel();

            var departments = db.Departments.ToList();
            var depsSelectList = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.ID.ToString() }).ToList();
            depsSelectList.Add(new SelectListItem { Text = "--Select Department--", Selected = true });

            ViewData["Deps"] = depsSelectList;
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeViewModel employeeViewModel)
        {
            var employee = employeeViewModel.MapToModel();
            db.Employees.Update(employee);
            db.SaveChanges();

            return RedirectToAction("Index");
        }



        public IActionResult GetData()
        {
            List<Employee>employees=new List<Employee>();
            string connectionString =
            "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Workforce_Test;Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT * FROM dbo.Employee";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var employee = new Employee()
                        {
                            Name= reader.GetString(0), 
                            Dob= reader.GetDateTime(2),
                            Contact=reader.GetString(4)
                            
                            
                          
                        };
                        employees.Add(employee);    

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return View(employees);
        }


    }
}
