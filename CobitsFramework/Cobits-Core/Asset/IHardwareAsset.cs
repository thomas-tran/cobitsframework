namespace Cobits.Core.Asset
{
    public interface IHardwareAsset : IAsset
    {
        string Sku { get; set; }
        string Model { get; set; }
        string Vendor { get; set; }
        string Description { get; set; }

    }
}
