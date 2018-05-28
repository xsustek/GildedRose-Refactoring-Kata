using System.Collections.Generic;

namespace csharp
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