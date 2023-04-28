using MFSAPI.Data;
using MFSAPI.Data.EFCore;
using MFSAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MFSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("GetAllPeople")]
        public async Task<ActionResult<IEnumerable<Person>>> GetAll()
        {
            var persons = await _personRepository.GetAll();

            return Ok(persons);
        }
    }
}
