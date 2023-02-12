using WorkForceManagement.web.Enum;

namespace WorkForceManagement.web.Models;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }=string.Empty;
    public string? Address { get; set; } =string.Empty;
    public Gender Gender { get; set; }
    public DateTime Dob { get; set; }
    public string Contact { get; set; } = string.Empty;
    public DateTime JoinDate { get; set; }
    public string Department { get; set; } = string.Empty;

}
