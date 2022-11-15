using Microsoft.AspNetCore.Mvc;
using Span.Culturio.Api.Services.User;
using Span.Culturio.Api.Models;
using Span.Culturio.Api.Services.Auth;

namespace Span.Culturio.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IAuthService _registerService;
        private readonly IConfiguration _configuration;

        public AuthController(ILogger<UsersController> logger, IAuthService registerService, IConfiguration configuration)
        {
            _logger = logger;
            _registerService = registerService;
            _configuration = configuration;
        }
        /// <summary>
        /// Register new user
        /// </summary>
        [HttpPost("register")]
        public async Task<ActionResult<RegisterUserDto>> RegisterUser([FromBody] UserDto user)
        {
            await _registerService.registerUser(user);
            return Ok();
        }
        /// <summary>
        /// Login
        /// </summary>
        [HttpPost("login")]
        public async Task<ActionResult<LoginDto>> LoginUser([FromBody] LoginDto user)
        {
            throw new NotImplementedException();
        // await _registerService.registerUser(user);
            return Ok();
        }


    }
    
}
