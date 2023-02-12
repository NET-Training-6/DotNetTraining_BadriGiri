using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WorkForceManagement.web.Data;
using WorkForceManagement.web.Models;

namespace WorkForceManagement.web.Controllers
{
    public class EmployeeController : Controller
    {
        WorkForceContext db = new WorkForceContext();

        [HttpGet]
        public IActionResult Index()
        {
           

            List<Employee> employeeList = db.Employees.ToList(); 
            return View(employeeList);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var employee=db.Employees.Find(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Add(int id) 
        {
            var employee= db.Employees.Find(id);
            db.SaveChanges();
            return View(employee);
            

        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
           db.Employees.Add(employee);
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
