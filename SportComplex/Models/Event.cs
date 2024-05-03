namespace SportComplex.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public string Location {  get; set; }
        public bool IsOutdoor {  get; set; }
        public string OrganizerName {  get; set; }
        public int Capacity {  get; set; }
    }
}
