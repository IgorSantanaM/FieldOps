using FieldOps.Inventory.Domain.Parts.Aggregates;
using FieldOps.Inventory.Domain.Warehouses.Aggregates;
using FieldOps.Inventory.Domain.Stock;
using FieldOps.Domain.Core.Model;
using FieldOps.Inventory.Domain.Warehouses;
using FieldOps.Inventory.Domain.Parts;

namespace FieldOps.Inventory.Domain.Stock.Aggregates;

public class StockBalance : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WarehouseId { get; private set; }
    public Guid PartId { get; private set; }
    public int OnHandQuantity { get; private set; }
    public int ReservedQuantity { get; private set; }
    public long Version { get; private set; }
    public Warehouse Warehouse { get; private set; } = null!;
    public Part Part { get; private set; } = null!;
}
