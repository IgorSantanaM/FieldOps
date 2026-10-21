using FieldOps.Billing.Domain.Payments;
using FieldOps.Domain.Core.Model;
using FieldOps.Billing.Domain.Payments.Enum;

namespace FieldOps.Billing.Domain.Payments.Aggregates;

public class PaymentWebhookReceipt : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public string Provider { get; private set; } = string.Empty;
    public string ProviderEventId { get; private set; } = string.Empty;
    public string PayloadHash { get; private set; } = string.Empty;
    public WebhookReceiptStatus Status { get; private set; }
    public DateTime ReceivedAtUtc { get; private set; }
    public DateTime? ProcessedAtUtc { get; private set; }
}
