using System.ComponentModel.DataAnnotations;

namespace SportComplex.Models;

public class Storage
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int Capacity { get; set; }
    public ICollection<string> Items { get; set; }
}