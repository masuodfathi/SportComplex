using System.ComponentModel.DataAnnotations;

namespace SportComplex.Models
{
    public class Salon
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Type { get; set; }
        
        public int TeamId { get; set; }
        public Team Team { get; set; }
        
        
    }
}