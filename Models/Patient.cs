namespace Hospital_Management_System.Models
{
    public class Patient
    {
        public int Id { get; set; }   // Auto-increment manually since using in-memory list
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string MedicalCondition { get; set; }
    }
}
