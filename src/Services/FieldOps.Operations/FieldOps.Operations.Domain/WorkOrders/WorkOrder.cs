using FieldOps.Domain.Core.Model;
using FieldOps.Domain.Customers;
using FieldOps.Domain.Assets;
using FieldOps.Domain.SlaPolicies.Enum;
using FieldOps.Domain.WorkOrders.Enum;
using FieldOps.Domain.ServiceReports;
using FieldOps.Domain.SlaPolicies;

namespace FieldOps.Domain.WorkOrders;

public class WorkOrder : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid CustomerId { get; private set; }
    public Guid AssetId { get; private set; }
    public string FaultCode { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public Priority Priority { get; private set; }
    public WorkOrderStatus Status { get; private set; }
    public DateTime RequestedStartUtc { get; private set; }
    public DateTime RequestedEndUtc { get; private set; }
    public string RegionCode { get; private set; } = string.Empty;
    public Guid PreferredWarehouseId { get; private set; }
    public string RequiredSkillCode { get; private set; } = string.Empty;
    public string Currency { get; private set; } = string.Empty;
    public decimal LaborRatePerHour { get; private set; }
    public Guid? AssignedTechnicianId { get; private set; }
    public Guid? AssignmentId { get; private set; }
    public Guid? ReservationId { get; private set; }
    public Guid? ActiveAllocationAttemptId { get; private set; }
    public DateTime? OpenedAtUtc { get; private set; }
    public DateTime? ResponseDueAtUtc { get; private set; }
    public DateTime? ResolutionDueAtUtc { get; private set; }
    public DateTime? StartedAtUtc { get; private set; }
    public DateTime? CompletedAtUtc { get; private set; }
    public long Version { get; private set; }
    public Customer Customer { get; private set; } = null!;
    public Asset Asset { get; private set; } = null!;
    public ServiceReport? ServiceReport { get; private set; }
    public IReadOnlyCollection<WorkOrderPartRequirement> PartRequirements { get; private set; } = new List<WorkOrderPartRequirement>();
    public IReadOnlyCollection<ResourceAllocationProcess> AllocationProcesses { get; private set; } = new List<ResourceAllocationProcess>();
    public IReadOnlyCollection<WorkOrderStatusHistory> StatusHistory { get; private set; } = new List<WorkOrderStatusHistory>();
    public IReadOnlyCollection<SlaBreach> SlaBreaches { get; private set; } = new List<SlaBreach>();
}
