using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using WorkForceManagement.web.Data;
using WorkForceManagement.web.Models;

namespace WrorkforceManagement.Api.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        WorkForceContext context = new WorkForceContext();
        [HttpGet]
        public IActionResult Get()
        {
            var employees=context.Employees.ToList();
            return Ok(employees);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employee=context.Employees.Find(id);
            if (employee == null) 
                return NotFound($"Employee with {id} doesnot exist");
            return Ok(employee);


        }
        [HttpPost]
        public IActionResult Post( Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return CreatedAtAction($"api/employees/{employee.ID}",employee);
        }
    }
}
