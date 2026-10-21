using FieldOps.Domain.Core.Model;

namespace FieldOps.Domain.ServiceReports;

public class ServiceReportPart : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid ServiceReportId { get; private set; }
    public Guid PartId { get; private set; }
    public int ConsumedQuantity { get; private set; }
    public ServiceReport ServiceReport { get; private set; } = null!;
}
