namespace MyAcademy.Models
{
    public class Student
    {
        public int Id { get; set; }
		public string LastName { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
		public DateOnly BirthDate { get; set; }
		public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Photo { get; set; }
        public int GroupNumber { get; set; }
    }
}