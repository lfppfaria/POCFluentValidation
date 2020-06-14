using Microsoft.AspNetCore.Mvc;
using POCFluentValidation.Model;
using POCFluentValidation.Validators;
using System.Threading.Tasks;

namespace POCFluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Running!");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            var validator = new PersonValidator();

            var validationResult = validator.Validate(person);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            return Ok();
        }
    }
}