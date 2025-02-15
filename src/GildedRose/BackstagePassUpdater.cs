using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class BackstagePassUpdater
    {
        public static void Update(Item backstagePassItem)
        {
            backstagePassItem.SellIn = backstagePassItem.SellIn - 1;
            backstagePassItem.Quality = CalculateQualityUpdate(backstagePassItem);
        }

        private static int CalculateQualityUpdate(Item backstagePassItem)
        {
            if (backstagePassItem.SellIn < 0)
            {
                return 0;
            }
            var updateValueBy = backstagePassItem.SellIn < 5 ? 3 : backstagePassItem.SellIn < 10 ? 2 : 1;
            var updatedQuality = backstagePassItem.Quality + updateValueBy;
            return updatedQuality >= 50 ? 50 : updatedQuality;
        }
    }
}