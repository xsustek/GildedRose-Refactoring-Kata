namespace csharp
{
    public class GildedRoseFactory
    {
        private const string AgedBrie = "Aged Brie";
        public static IGildedRose GetGildedRose(Item item)
        {
            switch (item.Name)
            {
                case AgedBrie:
                    return new GildedRoseAgedBrie();
                default:
                    return new GildedRoseBase();
            }
        }
    }
}