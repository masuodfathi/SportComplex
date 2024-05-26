namespace SportComplex.Dto
{
    public class EditLockerRoomDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public ICollection<CreateLockerDto> Lockers { get; set; } = new List<CreateLockerDto>();
    }
}
