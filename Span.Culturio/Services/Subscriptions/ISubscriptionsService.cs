using Span.Culturio.Api.Models;

namespace Span.Culturio.Api.Services.Subscriptions
{
    public interface ISubscriptionsService
    {
        Task<CreateSubscriptionDto> CreateSubscription(CreateSubscriptionDto createSubscriptionDto);
        Task<ActivateSubscriptionDto> ActivateSubscription(ActivateSubscriptionDto activateSubscriptionDto);
        Task<TrackVisitDto> TrackVisit(TrackVisitDto trackVisitDto);
        Task<IEnumerable<SubscriptionDto>> GetSubscriptions();
    }
}
