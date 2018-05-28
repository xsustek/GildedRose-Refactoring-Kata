using csharp.GildedRoseUpdater.Interface;

namespace csharp.GildedRoseUpdater.Base
{
    public class GildedRoseBase : 
        IGildedRose, 
        IGildeRoseInternal
    {
        public void UpdateItem(Item item)
        {
            UpdateQuality(item);
            UpdateSellIn(item);
        }

        public virtual void UpdateQuality(Item item)
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

        public virtual void UpdateSellIn(Item item)
        {
            item.SellIn--;
        }

        public virtual bool DegradeQuality => true;
    }
}