using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using WorkForceManagement.web.Enum;

namespace WorkForceManagement.web.ViewModels;

public class EmployeeViewModel
{
    public int ID { get; set; }

    [Required(ErrorMessage = "Enter Your Name"), MinLength(2, ErrorMessage = "Name should contain atleast length of 2")]
    public string Name { get; set; } = string.Empty;
    public string? Address { get; set; } = string.Empty;
    public Gender Gender { get; set; }


    [DisplayName("Date of birth")]
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }
    public string Contact { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }

    [DisplayName("Your Profile Image")]
    
    public IFormFile? ProfileImage { get; set; }

    public string ProfileImagePath { get; set; } = string.Empty;
    
    public int Department { get; set; }
    public string DepartmentName { get; set; }
}
