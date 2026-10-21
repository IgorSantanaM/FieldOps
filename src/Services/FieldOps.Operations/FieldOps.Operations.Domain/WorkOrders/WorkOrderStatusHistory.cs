using FieldOps.Domain.Core.Model;

namespace FieldOps.Domain.WorkOrders;

public class WorkOrderStatusHistory : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public string PreviousStatus { get; private set; } = string.Empty;
    public string NewStatus { get; private set; } = string.Empty;
    public string ActorRef { get; private set; } = string.Empty;
    public string? Reason { get; private set; }
    public DateTime OccurredAtUtc { get; private set; }
    public WorkOrder WorkOrder { get; private set; } = null!;
}
