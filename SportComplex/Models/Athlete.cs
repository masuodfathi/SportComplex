namespace SportComplex.Models;

public class Athlete
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Sport { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
}