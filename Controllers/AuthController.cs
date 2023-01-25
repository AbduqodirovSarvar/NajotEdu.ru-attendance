using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NajotEdu.ru.Interface;
using NajotEdu.ru.Registar;

namespace NajotEdu.ru.Controllers
{
    [Route("[api/controller]")]
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

        [HttpPost("Login")]
        public IActionResult PutLogin(LoginRegistr login)
        {
            return Ok();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
