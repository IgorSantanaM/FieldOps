using FieldOps.Domain.Core.Model;
using FieldOps.Domain.WorkOrders;
using FieldOps.Domain.ServiceReports.Enum;

namespace FieldOps.Domain.ServiceReports;

public class ServiceReport : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public Guid TechnicianId { get; private set; }
    public Guid CompletionRequestId { get; private set; }
    public string Diagnosis { get; private set; } = string.Empty;
    public string Resolution { get; private set; } = string.Empty;
    public int LaborMinutes { get; private set; }
    public DateTime SubmittedAtUtc { get; private set; }
    public ServiceReportStatus Status { get; private set; }
    public WorkOrder WorkOrder { get; private set; } = null!;
    public IReadOnlyCollection<ServiceReportPart> Parts { get; private set; } = new List<ServiceReportPart>();
}
