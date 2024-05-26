using SportComplex.Models;
using System.ComponentModel.DataAnnotations;

namespace SportComplex.Dto
{
    public class CreateLockerRoomDto
    {
       
        public string Name { get; set; }
        public int Capacity { get; set; }
        public ICollection<CreateLockerDto> Lockers { get; set; } = new List<CreateLockerDto>();
    }

    public class CreateLockerDto
    {
        public int Number { get; set; }
        public bool IsAvailable { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? ReservationStartTime { get; set; }
        public DateTime? ReservationEndTime { get; set; }
    }
}
