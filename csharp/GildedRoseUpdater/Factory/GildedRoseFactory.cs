namespace csharp.GildedRoseUpdater.Factory
{
    public class GildedRoseFactory
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public static Interface.IGildedRose GetGildedRose(Item item)
        {
            switch (item.Name)
            {
                case AgedBrie:
                    return new GildedRoseAgedBrie();
                case BackstagePass:
                    return new GildedRoseBackstagePass();
                case Sulfuras:
                    return new GildedRoseSulfuras();
                default:
                    return new Base.GildedRoseBase();
            }
        }
    }
}