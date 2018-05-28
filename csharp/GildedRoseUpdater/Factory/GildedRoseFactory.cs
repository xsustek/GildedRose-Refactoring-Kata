using System;
using csharp.GildedRoseUpdater.Base;
using csharp.GildedRoseUpdater.Interface;

namespace csharp.GildedRoseUpdater.Factory
{
    public class GildedRoseFactory
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        private const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        private const string Conjured = "Conjured";

        public static IGildedRose GetGildedRose(string itemName) => GetGildedRoseInternal(itemName);

        private static GildedRoseBase GetGildedRoseInternal(string itemName)
        {
            if (itemName.Contains(Conjured)) return GetGildedRoseConjured(itemName);
            switch (itemName)
            {
                case AgedBrie:
                    return new GildedRoseAgedBrie();
                case BackstagePass:
                    return new GildedRoseBackstagePass();
                case Sulfuras:
                    return new GildedRoseSulfuras();
                default:
                    return new GildedRoseBase();
            }
        }

        private static GildedRoseConjured GetGildedRoseConjured(string itemName)
        {
            return new GildedRoseConjured(
                GetGildedRoseInternal(itemName.Substring(itemName.IndexOf(" ", StringComparison.Ordinal) + 1)));
        }
    }
}