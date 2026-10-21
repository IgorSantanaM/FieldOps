using FieldOps.Inventory.Domain.Parts.Aggregates;
using FieldOps.Inventory.Domain.Reservations.Aggregates;
using FieldOps.Inventory.Domain.Warehouses.Aggregates;
using FieldOps.Domain.Core.Model;
using FieldOps.Inventory.Domain.Warehouses;
using FieldOps.Inventory.Domain.Parts;
using FieldOps.Inventory.Domain.Reservations;
using FieldOps.Inventory.Domain.Stock.Enum;

namespace FieldOps.Inventory.Domain.Stock;

public class StockMovement : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WarehouseId { get; private set; }
    public Guid PartId { get; private set; }
    public Guid? ReservationId { get; private set; }
    public Guid SourceOperationId { get; private set; }
    public MovementKind MovementKind { get; private set; }
    public int OnHandDelta { get; private set; }
    public string Reason { get; private set; } = string.Empty;
    public DateTime OccurredAtUtc { get; private set; }
    public Warehouse Warehouse { get; private set; } = null!;
    public Part Part { get; private set; } = null!;
    public StockReservation? Reservation { get; private set; }
}
