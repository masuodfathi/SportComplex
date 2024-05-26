namespace SportComplex.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Sprot_Type { get; set; }

        public int SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}