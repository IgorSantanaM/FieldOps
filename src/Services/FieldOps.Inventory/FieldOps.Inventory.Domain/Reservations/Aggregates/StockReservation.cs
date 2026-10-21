using FieldOps.Inventory.Domain.Warehouses.Aggregates;
using FieldOps.Inventory.Domain.Reservations;
using FieldOps.Domain.Core.Model;
using FieldOps.Inventory.Domain.Warehouses;
using FieldOps.Inventory.Domain.Reservations.Enum;

namespace FieldOps.Inventory.Domain.Reservations.Aggregates;

public class StockReservation : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public Guid AttemptId { get; private set; }
    public Guid WarehouseId { get; private set; }
    public ReservationStatus Status { get; private set; }
    public DateTime ExpiresAtUtc { get; private set; }
    public long Version { get; private set; }
    public Warehouse Warehouse { get; private set; } = null!;
    public IReadOnlyCollection<StockReservationLine> Lines { get; private set; } = new List<StockReservationLine>();
}
