namespace SportComplex.Models;

public class Storage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public List<string> Items { get; set; }
}