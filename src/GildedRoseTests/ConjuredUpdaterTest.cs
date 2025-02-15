using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class ConjuredUpdaterTest
    {
        [Fact]
        public void WhenTimePasses_QualityDecreasesByDouble()
        {
            var defaultItem = new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 10 };
            ConjuredUpdater.Update(defaultItem);

            Assert.Equal(8, defaultItem.Quality);
        }

        [Fact]
        public void WhenSellInPassed_QualityDecreasesBy4()
        {
            var defaultItem = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 10 };
            ConjuredUpdater.Update(defaultItem);

            Assert.Equal(6, defaultItem.Quality);
        }   
    }
}