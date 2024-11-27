using Microsoft.AspNetCore.Mvc;
using MVCGit.Models;
using Microsoft.Extensions.Logging;

namespace MVCGit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personName = new Name { PersonName = "Stephanie McKinney" };
            return Ok(personName);
        }
    }
}