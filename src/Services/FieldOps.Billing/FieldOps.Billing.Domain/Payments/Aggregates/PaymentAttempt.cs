using FieldOps.Billing.Domain.Invoices.Aggregates;
using FieldOps.Billing.Domain.Payments;
using FieldOps.Domain.Core.Model;
using FieldOps.Billing.Domain.Invoices;
using FieldOps.Billing.Domain.Payments.Enum;

namespace FieldOps.Billing.Domain.Payments.Aggregates;

public class PaymentAttempt : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid InvoiceId { get; private set; }
    public string Provider { get; private set; } = string.Empty;
    public string ProviderRequestKey { get; private set; } = string.Empty;
    public decimal Amount { get; private set; }
    public PaymentAttemptStatus Status { get; private set; }
    public DateTime RequestedAtUtc { get; private set; }
    public DateTime? ResolvedAtUtc { get; private set; }
    public Invoice Invoice { get; private set; } = null!;
}
