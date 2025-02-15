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
            BrieUpdater.Update(brieItem);

            Assert.Equal(1, brieItem.Quality);
        }

        [Fact]
        public void WhenSellIn_QualityIncreases()
        {
            var brieItem = new Item { Name = "Aged Brie", SellIn = 0, Quality = 2 };
            BrieUpdater.Update(brieItem);

            Assert.Equal(4, brieItem.Quality);
        }

        [Fact]
        public void QualityCapsAt50()
        {
            var brieItem = new Item { Name = "Aged Brie", SellIn = -1, Quality = 49 };
            BrieUpdater.Update(brieItem);

            Assert.Equal(50, brieItem.Quality);
        }
    }
}