namespace WorkForceManagement.web.Models;

public class Designation
{
    public int ID { get; set; }
    public string Title { get; set; }=string.Empty;
    public string Description { get; set; }=string.Empty;
    public string? PayRange { get; set; }
}
