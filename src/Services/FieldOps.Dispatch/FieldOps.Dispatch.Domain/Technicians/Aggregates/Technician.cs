using FieldOps.Dispatch.Domain.Assignments.Aggregates;
using FieldOps.Dispatch.Domain.Technicians;
using FieldOps.Domain.Core.Model;
using FieldOps.Dispatch.Domain.Technicians.Enum;
using FieldOps.Dispatch.Domain.Assignments;

namespace FieldOps.Dispatch.Domain.Technicians.Aggregates;

public class Technician : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string RegionCode { get; private set; } = string.Empty;
    public TechnicianStatus Status { get; private set; }
    public long Version { get; private set; }
    public IReadOnlyCollection<TechnicianSkill> Skills { get; private set; } = new List<TechnicianSkill>();
    public IReadOnlyCollection<TechnicianAvailability> Availability { get; private set; } = new List<TechnicianAvailability>();
    public IReadOnlyCollection<TechnicianTimeOff> TimeOff { get; private set; } = new List<TechnicianTimeOff>();
    public IReadOnlyCollection<TechnicianAssignment> Assignments { get; private set; } = new List<TechnicianAssignment>();
}
