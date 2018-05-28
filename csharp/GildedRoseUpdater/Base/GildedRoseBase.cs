namespace csharp.GildedRoseUpdater.Base
{
    public class GildedRoseBase : Interface.IGildedRose
    {
        public void UpdateItem(Item item)
        {
            UpdateQuality(item);
            UpdateSellIn(item);
        }

        protected virtual void UpdateQuality(Item item)
        {
            if(item.Quality <= 0) return;
            if (item.SellIn > 0)
            {
                item.Quality--;
            }
            else
            {
                item.Quality -= 2;
            }
        }

        protected virtual void UpdateSellIn(Item item)
        {
            item.SellIn--;
        }
    }
}