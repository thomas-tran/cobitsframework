using System.Collections.Generic;

namespace Cobits.Core.Asset
{
    public interface IPersonAsset : IAsset
    {
        string Username { get; set; }

        string EmailAddress { get; set; }

        IList<string> Roles { get; set; }
    }
}
