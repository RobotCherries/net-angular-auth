using Microsoft.AspNetCore.Mvc;

namespace net_angular_auth.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        [HttpGet("")]
        public IActionResult Register() {
            return Ok("Success");
        }
    }
}
