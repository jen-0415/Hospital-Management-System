namespace Hospital_Management_System.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public int Age { get; set; }
        public required string Address { get; set; }
        public required string ContactNumber { get; set; }
        public required string MedicalCondition { get; set; }
    }
}
