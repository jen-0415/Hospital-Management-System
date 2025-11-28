using Hospital_Management_System.Models;

namespace Hospital_Management_System.Data
{
    public class HospitalContext
    {
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
