using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3miniProject
{
    public class AssetTracker
    {
        private List<Asset> assets = new();
        public void AddAsset(Asset asset)
        {
            assets.Add(asset);
        }
        public List<Asset> GetAssets()
        {
            return assets;
        }
    }
}
