using FieldOps.Billing.Domain.Invoices.Aggregates;
using FieldOps.Domain.Core.Model;
using FieldOps.Billing.Domain.Invoices;

namespace FieldOps.Billing.Domain.Payments;

public class Payment : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid InvoiceId { get; private set; }
    public string Provider { get; private set; } = string.Empty;
    public string ProviderPaymentId { get; private set; } = string.Empty;
    public decimal Amount { get; private set; }
    public string Currency { get; private set; } = string.Empty;
    public DateTime ReceivedAtUtc { get; private set; }
    public Invoice Invoice { get; private set; } = null!;
}
