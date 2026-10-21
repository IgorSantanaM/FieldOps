using FieldOps.Domain.Core.Model;
using FieldOps.Domain.WorkOrders.Enum;

namespace FieldOps.Domain.WorkOrders;

public class ResourceAllocationProcess : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public Guid AttemptId { get; private set; }
    public InventoryAllocationState InventoryState { get; private set; }
    public DispatchAllocationState DispatchState { get; private set; }
    public Guid? ReservationId { get; private set; }
    public Guid? AssignmentId { get; private set; }
    public AllocationProcessStatus Status { get; private set; }
    public string? FailureReason { get; private set; }
    public long Version { get; private set; }
    public WorkOrder WorkOrder { get; private set; } = null!;
}
