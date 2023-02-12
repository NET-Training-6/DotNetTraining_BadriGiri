using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class studentController : Controller
    {
        public IActionResult Index()
        {
            //list of students
            Student student1= new() 
            { 
              Name="Badri Giri",
              Address="Sanothimi", 
              Gender=Sex.Male,
              Email="Badriaran10@gmail.com", 
              BOD= new DateTime(1999-11-15)
             };
            Student student2 = new()
            {
                Name = "Tolak Bhusal",
                Gender=Sex.Male,    
                Address = "Kupandol",
                Email = "tilakbhusal90@gmail.com",
                BOD = new DateTime(1999 - 10 - 15)
            };
            Student student3 = new()
            {
                Name = "Prabin Bhandari",
                Gender = Sex.Male,
                Address = "Kupandol",
                Email = "tbhusal90@gmail.com",
                BOD = new DateTime(1999 - 10 - 15)
            };

            List<Student> students = new() { student1,student2, student3 };

            return View(students);
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
