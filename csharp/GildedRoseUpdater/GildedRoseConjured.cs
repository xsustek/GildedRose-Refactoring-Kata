using System;
using csharp.GildedRoseUpdater.Base;
using csharp.GildedRoseUpdater.Interface;

namespace csharp.GildedRoseUpdater
{
    public class GildedRoseConjured : GildedRoseBase
    {
        private readonly IGildedRoseUpdateQualitySellIn gildedRose;

        internal GildedRoseConjured(IGildedRoseUpdateQualitySellIn gildedRose)
        {
            this.gildedRose = gildedRose;
        }

        public override void UpdateQuality(Item item)
        {
            Call(() => gildedRose.UpdateQuality(item), 2);
        }

        private void Call(Action action, int count)
        {
            for (var i = 0; i < count; i++)
            {
                action();
            }
        }
    }
}