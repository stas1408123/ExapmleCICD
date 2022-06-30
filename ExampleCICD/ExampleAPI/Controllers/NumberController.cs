using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumberController : ControllerBase
    {

        private readonly ILogger<NumberController> _logger;

        public NumberController(ILogger<NumberController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int GetFive()
        {
            return 5;
        }

    }
}
