using FieldOps.Dispatch.Domain.Technicians.Aggregates;
using FieldOps.Dispatch.Domain.Assignments;
using FieldOps.Domain.Core.Model;
using FieldOps.Dispatch.Domain.Technicians;
using FieldOps.Dispatch.Domain.Assignments.Enum;

namespace FieldOps.Dispatch.Domain.Assignments.Aggregates;

public class TechnicianAssignment : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid WorkOrderId { get; private set; }
    public Guid AttemptId { get; private set; }
    public Guid TechnicianId { get; private set; }
    public DateTime StartUtc { get; private set; }
    public DateTime EndUtc { get; private set; }
    public AssignmentStatus Status { get; private set; }
    public DateTime OfferExpiresAtUtc { get; private set; }
    public DateTime? AcceptedAtUtc { get; private set; }
    public long Version { get; private set; }
    public Technician Technician { get; private set; } = null!;
}
