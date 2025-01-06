using HealthHub.AppLogic;
using HealthHub.Domain;
using Microsoft.EntityFrameworkCore;

namespace HealthHub.Infrastructure
{
    internal class AppointmentsRepository: IAppointmentsRepository
    {
        private readonly HealthHubDbContext _context;

        public AppointmentsRepository(HealthHubDbContext context)
        {
            _context = context;
        }

        public IList<Appointment> GetAll()
        {
            return _context.Appointments.ToList();
        }

        public Appointment? GetById(int id)
        {
            return _context.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public void Update(Appointment appointment)
        {
            _context.Appointments.Attach(appointment);
            _context.Entry(appointment).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Appointment appointment)
        {
            _context.Appointments.Remove(appointment);
            _context.SaveChanges();
        }

        public IList<Appointment> GetAppointmentsForDoctor(int doctorId)
        {
            return _context.Appointments.Where(a => a.DoctorId == doctorId).ToList();
        }

        public IList<Appointment> GetAppointmentsForPatient(string patientNationalNumber)
        {
            return _context.Appointments.Where(a => a.PatientNationalNumber == patientNationalNumber).ToList();
        }

        public IList<Appointment> GetUpcomingAppointments(int daysAhead)
        {
            DateTime latestDate = DateTime.Now.AddDays(daysAhead);
            return _context.Appointments.Where(a => a.AppointmentDate <= latestDate && a.AppointmentDate > DateTime.Now).ToList();
        }
    }
}

