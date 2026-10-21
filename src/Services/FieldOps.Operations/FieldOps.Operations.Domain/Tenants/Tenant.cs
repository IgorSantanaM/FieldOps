using FieldOps.Domain.Core.Model;
using FieldOps.Domain.Tenants.Enum;

namespace FieldOps.Domain.Tenants;

public class Tenant : Entity<Guid>, IAggregateRoot
{
    public string LegalName { get; private set; } = string.Empty;
    public string TimeZoneId { get; private set; } = string.Empty;
    public string DefaultCurrency { get; private set; } = string.Empty;
    public TenantStatus Status { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
}
