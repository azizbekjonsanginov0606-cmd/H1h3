namespace Domain.Models;

public class Teacher
{
    public int Id;
    public string FirsName {get; set;}=string.Empty;
    public string LastName {get; set;}=string.Empty;
    public string Position {get; set;}=string.Empty;
    public int ExperienceAmount {get; set;}
}
