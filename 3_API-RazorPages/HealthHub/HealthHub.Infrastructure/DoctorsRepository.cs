using HealthHub.AppLogic;
using HealthHub.Domain;
using Microsoft.EntityFrameworkCore;

namespace HealthHub.Infrastructure
{
    internal class DoctorsRepository : IDoctorsRepository
    {
        private readonly HealthHubDbContext _context;

        public DoctorsRepository(HealthHubDbContext context)
        {
            _context = context;
        }

        public IList<Doctor> GetAll()
        {
            return _context.Doctors.ToList();
        }

        public Doctor? GetById(int id)
        {
            return _context.Doctors.FirstOrDefault(a => a.Id == id);
        }

        public IList<Doctor> GetDoctorsBySpecialty(int specialtyId)
        {
            return _context.Doctors.Where(a => a.SpecialtyId == specialtyId).ToList();
        }

        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void Update(Doctor doctor)
        {
            _context.Doctors.Attach(doctor);
            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Doctor doctor = GetById(id)!;
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
        }
    }
}
