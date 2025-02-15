using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void WhenItemPassedIn_ThenCorrectItemNameInResults()
        {
            const string itemName = "foo";
            IList<Item> Items = new List<Item> { new Item { Name = itemName, SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(itemName, Items[0].Name);
        }

        [Fact]
        public void GivenStandardItem_WhenTimePasses_SellInReduces()
        {
            const int expectedSellIn = -1;
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedSellIn, Items[0].SellIn);
        }

        [Fact]
        public void GivenStandardItem_WhenTimePasses_QualityReduces()
        {
            const int expectedQuality = 2;
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 3, Quality = 3 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}
