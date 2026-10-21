using FieldOps.Domain.Core.Model;
using FieldOps.Domain.Assets.Enum;
using FieldOps.Domain.Customers;
using FieldOps.Domain.Tenants;
using FieldOps.Domain.Core.SeedWork;

namespace FieldOps.Domain.Assets;

public class Asset : Entity<Guid>, IAggregateRoot
{
    public Guid TenantId { get; private set; }
    public DateTime CreatedAtUtc { get; private set; }
    public DateTime UpdatedAtUtc { get; private set; }
    public Guid CustomerId { get; private set; }
    public string SerialNumber { get; private set; } = string.Empty;
    public string Model { get; private set; } = string.Empty;
    public string Category { get; private set; } = string.Empty;
    public string RegionCode { get; private set; } = string.Empty;
    public string RequiredSkillCode { get; private set; } = string.Empty;
    public DateTime? WarrantyExpiresAtUtc { get; private set; }
    public AssetStatus Status { get; private set; }
    public Tenant Tenant { get; private set; }
    public Customer Customer { get; private set; } = null!;

    private Asset() { }

    public Asset(Tenant tenant, Customer customer, 
        string serialNumber, string model,
        string category, string regionCode, 
        string requiredSkillCode, DateTime? warrantyExpiresAtUtc = null,
        AssetStatus assetStatus = AssetStatus.Active)
    {
        Util.ThrowIfNull(tenant);
        Util.ThrowIfNull(customer);
        Util.ThrowIfNullOrWhitespace(serialNumber);
        Util.ThrowIfNullOrWhitespace(model);
        Util.ThrowIfNullOrWhitespace(category);
        Util.ThrowIfNullOrWhitespace(regionCode);
        Util.ThrowIfNullOrWhitespace(requiredSkillCode);

        Tenant = tenant;
        Customer = customer;
        SerialNumber = serialNumber;
        Model = model;
        Category = category;
        RegionCode = regionCode;
        RequiredSkillCode = requiredSkillCode;
        WarrantyExpiresAtUtc = warrantyExpiresAtUtc;
        Status = assetStatus;
    }

}
