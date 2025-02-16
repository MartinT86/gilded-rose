using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Updaters;

namespace GildedRoseTests.UpdaterTests
{
    public class BackstagePassesUpdaterTest
    {
        [Fact]
        public void WhenMoreThan10Days_IncreaseQuality()
        {
            var backstagePass = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 11,
                Quality = 20
            };
            BackstagePassUpdater.Update(backstagePass);

            Assert.Equal(21, backstagePass.Quality);
        }

        [Fact]
        public void When10DaysOrLess_IncreaseQualityBy2()
        {
            var backstagePass = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 20
            };
            BackstagePassUpdater.Update(backstagePass);

            Assert.Equal(22, backstagePass.Quality);
        }

        [Fact]
        public void When5DaysOrLess_IncreaseQualityBy3()
        {
            var backstagePass = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 20
            };
            BackstagePassUpdater.Update(backstagePass);

            Assert.Equal(23, backstagePass.Quality);
        }

        [Fact]
        public void WhenDayZero_QualityStillAbove0()
        {
            var backstagePass = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 1,
                Quality = 20
            };
            BackstagePassUpdater.Update(backstagePass);

            Assert.Equal(23, backstagePass.Quality);
        }

        [Fact]
        public void WhenAfterConcert_Quality0()
        {
            var backstagePass = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 0,
                Quality = 20
            };
            BackstagePassUpdater.Update(backstagePass);

            Assert.Equal(0, backstagePass.Quality);
        }
    }
}