using Hospital_Management_System.Data;
using Hospital_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System.Controllers
{
    public class PatientController : Controller
    {
        private readonly HospitalContext _context;

        public PatientController(HospitalContext context)
        {
            _context = context;
        }

        // LIST
        public IActionResult PatientList()
        {
            return View(_context.Patients);
        }

        // REGISTER FORM
        public IActionResult PatientRegister()
        {
            return View();
        }

        // POST: REGISTER
        [HttpPost]
        public IActionResult PatientRegister(Patient patient)
        {
            patient.Id = _context.Patients.Count + 1;
            _context.Patients.Add(patient);

            return RedirectToAction("PatientList");
        }

        // DETAILS
        public IActionResult PatientDetails(int id)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.Id == id);
            if (patient == null) return NotFound();

            return View(patient);
        }
    }
}
