using FieldOps.Domain.Core.Model;
using FieldOps.Domain.Tenants;
using FieldOps.Domain.Assets;
using FieldOps.Domain.Customers.Enum;
using System.Globalization;
using FieldOps.Domain.Core.Exceptions;
using FieldOps.Domain.Core.SeedWork;

namespace FieldOps.Domain.Customers;

public class Customer : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime? UpdatedAtUtc { get; private set; }
    public string DisplayName { get; private set; } = string.Empty;
    public string? Email { get; private set; }
    public string? Phone { get; private set; }
    public CustomerStatus Status { get; private set; }
    public Tenant Tenant { get; private set; } = null!;
    private readonly List<Asset> _assets = new();
    public IReadOnlyCollection<Asset> Assets { get; private set; } = new List<Asset>();

    private Customer() { }

    public Customer(Tenant tenant, string displayName, string email, string phone, CustomerStatus status = CustomerStatus.Active)
    {
        Util.ThrowIfNull(tenant);
        Util.ThrowIfNullOrWhitespace(displayName);
        Util.ThrowIfNullOrWhitespace(email);
        Util.ThrowIfNullOrWhitespace(phone);

        CreatedAtUtc = DateTime.UtcNow;
        DisplayName = displayName;
        Email = email;
        Phone = phone;
        Status = status;
        Tenant = tenant;
    }

    public void AddAsset(Asset asset)
    {
        Util.ThrowIfNull(asset);

        _assets.Add(asset);
    }


}