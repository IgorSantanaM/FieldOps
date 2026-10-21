using FieldOps.Domain.Core.Model;
using FieldOps.Notifications.Domain.Deliveries.Enum;

namespace FieldOps.Notifications.Domain.Deliveries;

public class NotificationDelivery : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid SourceMessageId { get; private set; }
    public string RecipientRef { get; private set; } = string.Empty;
    public NotificationChannel Channel { get; private set; }
    public string TemplateKey { get; private set; } = string.Empty;
    public DeliveryStatus Status { get; private set; }
    public int AttemptCount { get; private set; }
    public DateTime? NextAttemptAtUtc { get; private set; }
    public string? ProviderMessageId { get; private set; }
    public DateTime? SentAtUtc { get; private set; }
    public string? LastError { get; private set; }
}
