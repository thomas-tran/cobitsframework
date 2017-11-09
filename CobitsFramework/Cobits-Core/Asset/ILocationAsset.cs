namespace Cobits.Core.Asset
{
    public interface ILocationAsset : IAsset
    {
        double Longitute { get; set; }

        double Latitude { get; set; }

        double Elevation { get; set; }
    }
}
