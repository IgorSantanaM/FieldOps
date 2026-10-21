using FieldOps.Billing.Domain.Invoices.Aggregates;
using FieldOps.Domain.Core.Model;
using FieldOps.Billing.Domain.Invoices.Enum;

namespace FieldOps.Billing.Domain.Invoices;

public class InvoiceLine : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid InvoiceId { get; private set; }
    public InvoiceLineType LineType { get; private set; }
    public Guid? ReferenceId { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public decimal Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }
    public decimal LineAmount { get; private set; }
    public Invoice Invoice { get; private set; } = null!;
}
