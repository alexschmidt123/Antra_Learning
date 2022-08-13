using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("Calculation")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("Sum/{num1:int}/{num2:int}")]
        public async Task<IActionResult> GetSum(int num1, int num2)
        {
            return Ok(num1 + num2);
        }
    }
}
