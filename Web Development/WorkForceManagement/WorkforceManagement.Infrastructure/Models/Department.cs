using System.ComponentModel.DataAnnotations;

namespace WorkForceManagement.web.Models;

public class Department
{
    
    public int ID { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    [DataType(DataType.Date)]
    public DateTime Established { get; set; }
    public List<Employee> Employees { get; set; }
}
