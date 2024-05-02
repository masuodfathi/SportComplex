namespace SportComplex.Models;

public class LockerRoom
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Locker[] Lockers { get; set; }
}