using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult GetTestObject()
        {
            var testObject = new
            {
                message = "Hello, this is a test JSON object",
                timestamp = DateTime.UtcNow
            };

            return Ok(testObject);
        }
    }
}