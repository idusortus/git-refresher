using FSH.WebApi.Shared.Notifications;

namespace BLAZOR.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;