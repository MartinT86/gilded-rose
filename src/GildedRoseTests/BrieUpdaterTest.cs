using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class BrieUpdaterTest
    {
        [Fact]
        public void WhenTimePasses_QualityIncreases()
        {
            var brieItem = new Item { Name = "Aged Brie", SellIn = 1, Quality = 0 };
            var updatedItem = BrieUpdater.Update(brieItem);

            Assert.Equal(1, updatedItem.Quality);
        }

        [Fact]
        public void WhenSellIn_QualityIncreases()
        {
            var brieItem = new Item { Name = "Aged Brie", SellIn = 0, Quality = 2 };
            var updatedItem = BrieUpdater.Update(brieItem);

            Assert.Equal(4, updatedItem.Quality);
        }

        [Fact]
        public void QualityCapsAt50()
        {
            var brieItem = new Item { Name = "Aged Brie", SellIn = -1, Quality = 49 };
            var updatedItem = BrieUpdater.Update(brieItem);

            Assert.Equal(50, updatedItem.Quality);
        }
    }
}