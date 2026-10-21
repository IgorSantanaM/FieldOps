using FieldOps.Domain.Core.Model;
using FieldOps.Domain.WorkOrders;
using FieldOps.Domain.SlaPolicies.Enum;

namespace FieldOps.Domain.SlaPolicies;

public class SlaBreach : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public SlaKind SlaKind { get; private set; }
    public int EscalationLevel { get; private set; }
    public DateTime DeadlineUtc { get; private set; }
    public DateTime DetectedAtUtc { get; private set; }
    public WorkOrder WorkOrder { get; private set; } = null!;
}
