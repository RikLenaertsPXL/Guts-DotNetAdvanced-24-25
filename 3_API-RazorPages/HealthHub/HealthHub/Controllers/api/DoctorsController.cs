using HealthHub.AppLogic;
using HealthHub.Domain;
using HealthHub.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace HealthHub.Controllers.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorsRepository _doctorsRepository;
        public DoctorsController(IDoctorsRepository doctorRepository)
        {
            _doctorsRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_doctorsRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var doctor = _doctorsRepository.GetById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return Ok(doctor);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _doctorsRepository.Add(doctor);
            return CreatedAtAction(nameof(Get), new { id = doctor.Id }, doctor);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Doctor updatedDoctor)
        {
            var exisitingDoctor = _doctorsRepository.GetById(id);
            _doctorsRepository.Update(exisitingDoctor);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Doctor? doctor = _doctorsRepository.GetById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            _doctorsRepository.Delete(id);
            return NoContent();
        }

        [HttpGet("specialty/{specialtyId}")]
        public IActionResult GetDoctorsBySpecialty(int specialtyId)
        {
            var doctors = _doctorsRepository.GetDoctorsBySpecialty(specialtyId);
            if (doctors == null)
            {
                return NotFound();
            }
            return Ok(doctors);
        }
    }
}
