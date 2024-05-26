namespace SportComplex.Models;

public class Locker
{
    
        public int Id { get; set; }
        public int Number { get; set; }
        public bool IsAvailable { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? ReservationStartTime { get; set; }
        public DateTime? ReservationEndTime { get; set; }
        public int LockerRoomId { get; set; }// Required foreign key property
        public LockerRoom LockerRoom { get; set; } = null;// Required reference navigation to principal
}