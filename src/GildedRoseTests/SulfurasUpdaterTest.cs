using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class SulfurasUpdaterTest
    {
        [Fact]
        public void WhenSulfura_SellInStaysTheSameQuality80()
        {
            var sulfuraItem = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 5 };
            SulfurasUpdater.Update(sulfuraItem);

            Assert.Equal(1, sulfuraItem.SellIn);
            Assert.Equal(80, sulfuraItem.Quality);
        }
    }
}