using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void SellInDegradation()
        {
            IList<Item> items = new List<Item> {new Item {Name = "Good", SellIn = 10, Quality = 10}};
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].SellIn, Is.EqualTo(9));
        }

        [Test]
        public void SellInDegradationTwoItems()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Good", SellIn = 9, Quality = 12},
                new Item {Name = "Good2", SellIn = 15, Quality = 8}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items.Single(i => i.Name == "Good").SellIn, Is.EqualTo(8));
            Assert.That(items.Single(i => i.Name == "Good2").SellIn, Is.EqualTo(14));
        }

        [Test]
        public void QualityDegradation()
        {
            IList<Item> items = new List<Item> {new Item {Name = "Good", SellIn = 10, Quality = 10}};
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(9));
        }

        [Test]
        public void QualityDegradationTwoItems()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Good", SellIn = 9, Quality = 12},
                new Item {Name = "Good2", SellIn = 15, Quality = 8}
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items.Single(i => i.Name == "Good").Quality, Is.EqualTo(11));
            Assert.That(items.Single(i => i.Name == "Good2").Quality, Is.EqualTo(7));
        }
    }
}