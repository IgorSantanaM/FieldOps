using FieldOps.Domain.Core.Model;

namespace FieldOps.Domain.WorkOrders;

public class WorkOrderPartRequirement : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public Guid PartId { get; private set; }
    public int RequestedQuantity { get; private set; }
    public decimal? ReservedUnitPrice { get; private set; }
    public WorkOrder WorkOrder { get; private set; } = null!;
}
