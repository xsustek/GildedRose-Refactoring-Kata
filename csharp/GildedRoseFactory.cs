namespace csharp
{
    public class GildedRoseFactory
    {
        public static IGildedRose GetGildedRose(Item item)
        {
            switch (item.Name)
            {
                default:
                    return new GildedRoseBase();
            }
        }
    }
}