using Microsoft.AspNetCore.Mvc;
using TubesKPL.Models;
using TubesKPL.Services;

namespace TubesKPL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController()
        {
            _authService = new AuthService();
        }

        // REGISTER
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            var result = _authService.Register(user);

            if (result == "Register berhasil")
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        // LOGIN
        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            var result = _authService.Login(user);

            if (result == "Login berhasil")
            {
                return Ok(result);
            }

            return Unauthorized(result);
        }

        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var users = _authService.GetAllUsers();

            return Ok(users);
        }
    }
}