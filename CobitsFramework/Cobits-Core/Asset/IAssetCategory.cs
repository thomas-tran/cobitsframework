namespace Cobits.Core.Asset
{
    public interface IAssetCategory
    {
         string Id { get; set; }
         string Name { get; set; }

         AssetType AssetType { get; set; }
    }
}
