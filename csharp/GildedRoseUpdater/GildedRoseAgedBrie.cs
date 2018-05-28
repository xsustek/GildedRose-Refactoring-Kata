using csharp.GildedRoseUpdater.Base;

namespace csharp.GildedRoseUpdater
{
    public class GildedRoseAgedBrie : GildedRoseBase
    {
        public override void UpdateQuality(Item item)
        {
            if (item.Quality < 50) item.Quality++;
        }
    }
}