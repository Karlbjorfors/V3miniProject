using System;

namespace V3miniProject
{
    public class AssetData
    {
        public static void Main()
        {
            var tracker = new AssetTracker();
            var assetManager = new AssetManager();
            var assetSorter = new AssetSorter();
            var assetDisplay = new AssetDisplay();

            // Add assets dynamically based on user input
            UserInput.AddAssetsFromUserInput(tracker, assetManager);



            var assets = tracker.GetAssets();
            var sortedAssets = assetSorter.SortAssets(assets);
            assetDisplay.DisplayAssets(sortedAssets);
        }
    }
}
