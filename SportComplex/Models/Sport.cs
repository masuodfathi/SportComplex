using System.ComponentModel.DataAnnotations;

namespace SportComplex.Models;

public class Sport
{
    public int Id { get; set; }
    [Required]
    [MinLength(3)]
    public string Name { get; set; }
    public string Description { get; set; }
    public Athlete Athlete { get; set; }
}