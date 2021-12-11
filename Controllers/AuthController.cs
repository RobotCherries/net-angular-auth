using Microsoft.AspNetCore.Mvc;

namespace NetAngularAuth.Controllers
{
    [ApiController]    public class AuthController: Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return Ok("Success");
        }
    }
}
