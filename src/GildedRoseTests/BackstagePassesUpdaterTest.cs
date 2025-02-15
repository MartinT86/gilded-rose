using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class BackstagePassesUpdaterTest
    {
        [Fact]
        public void WhenMoreThan10Days_IncreaseQuality()
        {
            var backstagePass = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            };
            BackstagePassUpdater.Update(backstagePass);

            Assert.Equal(21, backstagePass.Quality);
        }
    }
}