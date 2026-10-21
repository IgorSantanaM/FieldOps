using FieldOps.Dispatch.Domain.Technicians.Aggregates;
using FieldOps.Domain.Core.Model;

namespace FieldOps.Dispatch.Domain.Technicians;

public class TechnicianAvailability : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid TechnicianId { get; private set; }
    public DateTime StartUtc { get; private set; }
    public DateTime EndUtc { get; private set; }
    public Technician Technician { get; private set; } = null!;
}
