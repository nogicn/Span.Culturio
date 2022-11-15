using Microsoft.AspNetCore.Mvc;
using Span.Culturio.Api.Services.User;

namespace Span.Culturio.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public PackagesController(ILogger<UsersController> logger, IUserService userService, IConfiguration configuration)
        {
            _logger = logger;
            _userService = userService;
            _configuration = configuration;
        }
        /// <summary>
        /// Get packages
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<PackagesController>>> GetPackages()
        {
            throw new NotImplementedException();
        }
    }
}
