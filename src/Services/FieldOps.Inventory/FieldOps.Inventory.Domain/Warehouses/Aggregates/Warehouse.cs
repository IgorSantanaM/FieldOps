using FieldOps.Inventory.Domain.Warehouses;
using FieldOps.Domain.Core.Model;
using FieldOps.Inventory.Domain.Warehouses.Enum;

namespace FieldOps.Inventory.Domain.Warehouses.Aggregates;

public class Warehouse : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public string Code { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public WarehouseStatus Status { get; private set; }
}
