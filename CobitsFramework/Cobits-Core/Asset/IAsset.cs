using System.Collections.Generic;

namespace Cobits.Core.Asset
{
    public interface IAsset
    {
         string Id { get; set; }

         string Name { get; set; }

         AssetType AssetType { get; set; }

         string CategoryId { get; set; }

         string ImageUrl { get; set; }

         Dictionary<string,string> Properties { get; set; }
    }
}
