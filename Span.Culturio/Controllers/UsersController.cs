using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Span.Culturio.Api.Models;
using Span.Culturio.Api.Services.User;

namespace Span.Culturio.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public UsersController(ILogger<UsersController> logger, IUserService userService, IConfiguration configuration)
        {
            _logger = logger;
            _userService = userService;
            _configuration = configuration;
        }

        /// <summary>
        /// Get users
        /// </summary>
        [HttpGet]//, Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<UserDto>>> GetUsers()
        {
            var users = await _userService.GetUsers();
            return Ok(users);
        }
        /// <summary>
        /// Get single user by Id
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUser(int id)
        {
            var user = await _userService.GetUser(id);
            if (user is null)
                return NotFound("User not found");

            return Ok(user);
        }

       
    }
}
