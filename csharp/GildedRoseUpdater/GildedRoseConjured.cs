using System;
using csharp.GildedRoseUpdater.Base;
using csharp.GildedRoseUpdater.Interface;

namespace csharp.GildedRoseUpdater
{
    public class GildedRoseConjured : GildedRoseBase
    {
        private readonly IGildeRoseInternal gildedRose;

        internal GildedRoseConjured(IGildeRoseInternal gildedRose)
        {
            this.gildedRose = gildedRose;
        }

        public override void UpdateQuality(Item item)
        {
            Call(() => gildedRose.UpdateQuality(item), gildedRose.DegradeQuality ? 2 : 1);
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