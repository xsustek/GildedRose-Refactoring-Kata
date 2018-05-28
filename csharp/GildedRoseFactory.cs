namespace csharp
{
    public class GildedRoseFactory
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        public static IGildedRose GetGildedRose(Item item)
        {
            switch (item.Name)
            {
                case AgedBrie:
                    return new GildedRoseAgedBrie();
                case BackstagePass:
                    return new GildedRoseBackstagePass();
                default:
                    return new GildedRoseBase();
            }
        }
    }
}