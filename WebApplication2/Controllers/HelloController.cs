using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace YourNamespace.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class HelloController : ControllerBase
        {
            [HttpGet]
            public IActionResult Get()
            {
                return Ok("Hello World");
            }
        }
    }

}

