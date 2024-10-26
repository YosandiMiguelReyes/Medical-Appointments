using MediacalAppointment.Persistence.Interfaces.Users;
using MediacalAppointment.Persistence.Repositories.Users;
using MedicalAppointment.Domain.Entities.Users;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointment.Users.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DoctorController>
        [HttpPost("Add")]
        public async Task<ActionResult> Post([FromBody] Doctors doctors)
        {
            var result = await _doctorRepository.Add(doctors);

            if (!result.Success) 
            {
                return BadRequest(result);
            }

            return Ok();
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
