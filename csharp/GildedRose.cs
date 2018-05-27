﻿using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> items;

        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                GildedRoseFactory.GetGildedRose(item).UpdateItem(item);
            }
        }
    }
}