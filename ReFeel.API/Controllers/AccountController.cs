using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReFEEL.Models;

namespace ReFEEL.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            // Implement your authentication logic here.

            return Ok();
        }
    }
}
