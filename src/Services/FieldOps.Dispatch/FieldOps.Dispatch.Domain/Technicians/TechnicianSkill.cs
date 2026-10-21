using FieldOps.Dispatch.Domain.Technicians.Aggregates;
using FieldOps.Domain.Core.Model;

namespace FieldOps.Dispatch.Domain.Technicians;

public class TechnicianSkill : Entity<Guid>
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid TechnicianId { get; private set; }
    public string SkillCode { get; private set; } = string.Empty;
    public DateTime? CertificationExpiresAtUtc { get; private set; }
    public Technician Technician { get; private set; } = null!;
}
