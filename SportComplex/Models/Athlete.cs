using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportComplex.Models
{
    public class Athlete
    {
        public int Id { get; set; }

        [MaxLength(15)]
        [MinLength(3)]
        public string FirstName { get; set; }

        [MaxLength(15)]
        [MinLength(3)]
        public string LastName { get; set; }

        [MaxLength(20)]
        [MinLength(5)]
        public string Email { get; set; }

        [MaxLength(11)]
        [MinLength(11)]
        public string PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }
        
        [ForeignKey("Sport")]
        public int SportId { get; set; } // Foreign key property
        
        public Sport Sport { get; set; } // Navigation property
    }
}