using Microsoft.AspNetCore.Mvc;
using Span.Culturio.Api.Models;
using Span.Culturio.Api.Services.User;

namespace Span.Culturio.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public SubscriptionsController(ILogger<UsersController> logger, IUserService userService, IConfiguration configuration)
        {
            _logger = logger;
            _userService = userService;
            _configuration = configuration;
        }

        /// <summary>
        /// Create a subscription
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<CreateSubscriptionDto>> CreateSubscription()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get user subscriptions
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<CreateSubscriptionDto>>> GetSubscripton()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Track single visit
        /// </summary>
        [HttpGet("track-visit")]
        public async Task<ActionResult<TrackVisitDto>> TrackVisit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Activate subscription
        /// </summary>
        [HttpGet("activate")]
        public async Task<ActionResult<ActivateSubscriptionDto>> Activate()
        {
            return Ok();
        }
    }
}
