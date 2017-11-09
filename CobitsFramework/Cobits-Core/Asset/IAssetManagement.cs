using System.Collections.Generic;
using Cobits.Core.Search;

namespace Cobits.Core.Asset
{
    public  interface IAssetManagement
    {
        IAssetCategory CreateAssetCategory(IAssetCategory request);

        IAssetCategory GetAssetCategory(string categoryId);

        IAssetCategory UpdateAssetCategory(string categoryId, IAssetCategory request);

        IAssetCategory RemoveAssetCategory(string categoryId);

        IList<IAssetCategory> AssetCategories(ISearchQuery query);

        IPersonAsset CreatePersonAsset(string categoryId, IPersonAsset request);

        IPersonAsset UpdatePersonAsset(string categoryId, string assetId, IPersonAsset request);


        IHardwareAsset CreateHardwareAsset(string categoryId, IHardwareAsset request);

        IHardwareAsset UpdateHardwareAsset(string categoryId, string assetId, IHardwareAsset request);


        ILocationAsset CreateLocationAsset(string categoryId, ILocationAsset request);

        ILocationAsset UpdateLocationAsset(string categoryId, string assetId, ILocationAsset request);

        IAsset GetAsset(string categoryId, string assetId);


        IAsset RemoveAsset(string categoryId, string assetId);

        IList<IAsset> ListAssets(string categoryId, ISearchQuery query);

    }
}
