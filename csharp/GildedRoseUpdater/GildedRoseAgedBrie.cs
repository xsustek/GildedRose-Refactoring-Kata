using csharp.GildedRoseUpdater.Base;

namespace csharp.GildedRoseUpdater
{
    public class GildedRoseAgedBrie : GildedRoseBase
    {
        protected override void UpdateQuality(Item item)
        {
            if(item.Quality == 50) return;
            item.Quality++;
        }
    }
}