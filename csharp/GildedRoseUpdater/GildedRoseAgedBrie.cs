namespace csharp.GildedRoseUpdater
{
    public class GildedRoseAgedBrie : Base.GildedRoseBase
    {
        protected override void UpdateQuality(Item item)
        {
            if(item.Quality == 50) return;
            item.Quality++;
        }
    }
}