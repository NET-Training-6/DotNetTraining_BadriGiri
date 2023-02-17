using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WorkForceManagement.web.Enum;

namespace WorkForceManagement.web.Models;

public class Employee
{
    public int ID { get; set; }

    [Required(ErrorMessage ="Enter Your Name"), MinLength(2, ErrorMessage = "Name should contain atleast length of 2")]
    public string Name { get; set; }=string.Empty;
    public string? Address { get; set; } =string.Empty;
    public Gender Gender { get; set; }


    [DisplayName("Date of birth")]
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }
    public string Contact { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }
    public string Department { get; set; } = string.Empty;

    [DisplayName("Your Profile Image")]
    [NotMapped]
    public IFormFile? ProfileImage { get; set; }

    public string ProfileImagePath { get; set; } = string.Empty;

}
