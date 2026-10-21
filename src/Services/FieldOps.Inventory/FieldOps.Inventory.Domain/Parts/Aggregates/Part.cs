using FieldOps.Inventory.Domain.Parts;
using FieldOps.Domain.Core.Model;
using FieldOps.Inventory.Domain.Parts.Enum;

namespace FieldOps.Inventory.Domain.Parts.Aggregates;

public class Part : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public string SKU { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public decimal UnitSalePrice { get; private set; }
    public string Currency { get; private set; } = string.Empty;
    public PartStatus Status { get; private set; }
}
