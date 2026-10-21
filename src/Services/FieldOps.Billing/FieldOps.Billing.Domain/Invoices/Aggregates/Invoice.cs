using FieldOps.Billing.Domain.Payments.Aggregates;
using FieldOps.Billing.Domain.Invoices;
using FieldOps.Domain.Core.Model;
using FieldOps.Billing.Domain.Invoices.Enum;
using FieldOps.Billing.Domain.Payments;

namespace FieldOps.Billing.Domain.Invoices.Aggregates;

public class Invoice : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public Guid CustomerId { get; private set; }
    public string InvoiceNumber { get; private set; } = string.Empty;
    public Guid SourceCompletionId { get; private set; }
    public string Currency { get; private set; } = string.Empty;
    public decimal TotalAmount { get; private set; }
    public InvoiceStatus Status { get; private set; }
    public DateTime IssuedAtUtc { get; private set; }
    public DateTime? PaidAtUtc { get; private set; }
    public long Version { get; private set; }
    public Payment? Payment { get; private set; }
    public IReadOnlyCollection<InvoiceLine> Lines { get; private set; } = new List<InvoiceLine>();
    public IReadOnlyCollection<PaymentAttempt> PaymentAttempts { get; private set; } = new List<PaymentAttempt>();
}
