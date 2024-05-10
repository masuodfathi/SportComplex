using System.ComponentModel.DataAnnotations.Schema;

namespace SportComplex.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }
        
    }
}
