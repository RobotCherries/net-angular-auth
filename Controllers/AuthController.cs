using Microsoft.AspNetCore.Mvc;

namespace NetAngularAuth.Controllers
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
