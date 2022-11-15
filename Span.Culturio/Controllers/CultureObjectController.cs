using Microsoft.AspNetCore.Mvc;
using Span.Culturio.Api.Models;
using Span.Culturio.Api.Services.User;

namespace Span.Culturio.Api.Controllers
{
    public class CultureObjectController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public CultureObjectController(ILogger<UsersController> logger, IUserService userService, IConfiguration configuration)
        {
            _logger = logger;
            _userService = userService;
            _configuration = configuration;
        }
        /// <summary>
        /// Create new culture object
        /// </summary>
        [HttpPost("culture-objects")]
        public async Task<ActionResult<CreateCultureObjectDto>> CreateCulture()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get culture objects
        /// </summary>
        [HttpGet("culture-objects")]
        public async Task<ActionResult<List<CultureObjectDto>>> GetCultures()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get culture object by Id
        /// </summary>
        [HttpGet("culture-objects/{id}")]
        public async Task<ActionResult<CultureObjectDto>> getCulture()
        {
            throw new NotImplementedException();
        }
        
    }
}
