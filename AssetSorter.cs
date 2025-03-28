using System.Collections.Generic;
using System.Linq;

namespace V3miniProject
{
    public class AssetSorter
    {
        public List<Asset> SortAssets(List<Asset> assets)
        {
            return assets
                .OrderBy(a => ((dynamic)a).Office.OfficeName)
                .ThenBy(a => a.PurchaseDate)
                .ToList();
        }
    }
}