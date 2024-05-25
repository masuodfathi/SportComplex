namespace SportComplex.Models;

using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

public class LockerRoom
{
    [Required]
    public int Id { get; set; }
    [MinLength(3)]
    [MaxLength(25)]
    public string Name { get; set; }
    [Required]
    public int Capacity { get; set; }
    public ICollection<Locker> Lockers { get; set; } = new List<Locker>();
}