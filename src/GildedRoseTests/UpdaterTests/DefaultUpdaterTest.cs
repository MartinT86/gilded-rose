using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Updaters;

namespace GildedRoseTests.UpdaterTests
{
    public class DefaultUpdaterTest
    {
        [Fact]
        public void WhenTimePasses_QualityDecreases()
        {
            var defaultItem = new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 10 };
            DefaultUpdater.Update(defaultItem);

            Assert.Equal(9, defaultItem.Quality);
        }

        [Fact]
        public void WhenSellInPassed_QualityDecreasesBy2()
        {
            var defaultItem = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 10 };
            DefaultUpdater.Update(defaultItem);

            Assert.Equal(8, defaultItem.Quality);
        }   

        [Fact]
        public void QualityIsNeverNegative()
        {
            var defaultItem = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 0 };
            DefaultUpdater.Update(defaultItem);

            Assert.Equal(0, defaultItem.Quality);
        }   
    }
}