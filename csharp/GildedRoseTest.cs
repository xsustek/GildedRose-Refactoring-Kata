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

        [Test]
        public void QualityDegradationWithSellInZero()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Good", SellIn = 0, Quality = 12},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(10));
            
        }

        [Test]
        public void QualityDegradationNeverNegative()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Good", SellIn = 7, Quality = 0},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(0));
        }

        [Test]
        public void AgedBrieIncreaseQuality()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 0},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(1));
        }

        [Test]
        public void AgedBrieIncreaseQualityNotMoreThan50()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 49},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(50));
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(50));
        }

        [Test]
        public void BackstagePassQualityIncrease()
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(21));
        }

        [Test]
        [TestCase(10, 22)]
        [TestCase(9, 22)]
        [TestCase(8, 22)]
        [TestCase(7, 22)]
        [TestCase(6, 22)]
        public void BackstagePassQualityIncreaseSellInBy2(int sellIn, int expectedQuality)
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(expectedQuality));
        }

        [Test]
        [TestCase(5, 23)]
        [TestCase(4, 23)]
        [TestCase(3, 23)]
        [TestCase(2, 23)]
        [TestCase(1, 23)]
        public void BackstagePassQualityIncreaseSellInBy3(int sellIn, int expectedQuality)
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(expectedQuality));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void BackstagePassQualityZeroWhenZeroOrNegativeSellIn(int sellIn)
        {
            IList<Item> items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = 20},
            };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(0));
        }
    }
}