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
    }
}