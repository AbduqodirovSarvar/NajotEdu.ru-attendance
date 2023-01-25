using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NajotEdu.ru.Interface;
using NajotEdu.ru.Registar;

namespace NajotEdu.ru.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthController : Controller
    {
        private readonly IAuthServer _authServer;
        private readonly ILogger<AuthController> _logger;
        public AuthController(IAuthServer authServer, ILogger<AuthController> logger)
        {
            _authServer = authServer;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRegistr login)
        {
            try
            {
                var token = await _authServer.Login(login);

                return Ok(token);
            }
            catch (Exception exx)
            {
                return BadRequest("Username or Password is not valid");
            }
        }
        
    }
}
