using FSH.WebApi.Shared.Notifications;

namespace BLAZOR.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}