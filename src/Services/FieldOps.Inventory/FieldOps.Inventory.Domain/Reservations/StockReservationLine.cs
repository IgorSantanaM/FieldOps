using FieldOps.Inventory.Domain.Parts.Aggregates;
using FieldOps.Inventory.Domain.Reservations.Aggregates;
using FieldOps.Domain.Core.Model;
using FieldOps.Inventory.Domain.Parts;

namespace FieldOps.Inventory.Domain.Reservations;

public class StockReservationLine : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid ReservationId { get; private set; }
    public Guid PartId { get; private set; }
    public int ReservedQuantity { get; private set; }
    public int ConsumedQuantity { get; private set; }
    public decimal UnitSalePriceSnapshot { get; private set; }
    public StockReservation Reservation { get; private set; } = null!;
    public Part Part { get; private set; } = null!;
}

