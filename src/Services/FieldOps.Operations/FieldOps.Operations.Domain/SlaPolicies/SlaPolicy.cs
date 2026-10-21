using FieldOps.Domain.Core.Model;
using FieldOps.Domain.SlaPolicies.Enum;

namespace FieldOps.Domain.SlaPolicies;

public class SlaPolicy : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Priority Priority { get; private set; }
    public int ResponseMinutes { get; private set; }
    public int ResolutionMinutes { get; private set; }
    public int EscalationIntervalMinutes { get; private set; }
    public DateTime EffectiveFromUtc { get; private set; }
    public DateTime? EffectiveToUtc { get; private set; }
}
