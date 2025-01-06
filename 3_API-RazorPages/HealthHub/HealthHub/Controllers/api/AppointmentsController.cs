using HealthHub.AppLogic;
using HealthHub.Domain;
using HealthHub.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthHub.Controllers.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentsRepository _appointmentsRepository;
        public AppointmentsController(IAppointmentsRepository appointmentsRepository)
        {
            _appointmentsRepository = appointmentsRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_appointmentsRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var appointment = _appointmentsRepository.GetById(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return Ok(appointment);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Appointment appointment)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _appointmentsRepository.Add(appointment);
            return CreatedAtAction(nameof(Get), new { id = appointment.Id }, appointment);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Appointment updatedAppointment)
        {
            var existingAppointment = _appointmentsRepository.GetById(id);
            _appointmentsRepository.Update(existingAppointment);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Appointment? appointment = _appointmentsRepository.GetById(id);
            if (!ModelState.IsValid || appointment == null)
            {
                return NotFound();
            }
            _appointmentsRepository.Delete(appointment);
            return NoContent();
        }

        [HttpGet("doctor/{doctorId}")]
        public IActionResult GetAppointmentsForDoctor(int doctorId)
        {
            var appointments = _appointmentsRepository.GetAppointmentsForDoctor(doctorId);
            if (appointments == null)
            {
                return NotFound();
            }
            return Ok(appointments);
        }

        [HttpGet("patient/{patientNationalNumber}")]
        public IActionResult GetAppointmentsForPatient(string patientNationalNumber)
        {
            var appointments = _appointmentsRepository.GetAppointmentsForPatient(patientNationalNumber);
            if (appointments == null)
            {
                return NotFound();
            }
            return Ok(appointments);
        }

        [HttpGet("upcoming")]
        public IActionResult GetUpcomingAppointments([FromQuery] int daysAhead)
        {
            var appointments = _appointmentsRepository.GetUpcomingAppointments(daysAhead);
            if (appointments == null)
            {
                return NotFound();
            }
            return Ok(appointments);
        }
    }
}
