using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata.Updaters
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
            var updateValueBy = backstagePassItem.SellIn < 5 ? Constants.Qualities.BackstagePassMaxIncrease
                : backstagePassItem.SellIn < 10 ? Constants.Qualities.BackstagePassMidIncrease
                : Constants.Qualities.BackstagePassMinIncrease;
            var updatedQuality = backstagePassItem.Quality + updateValueBy;
            return updatedQuality >= Constants.Qualities.Maximum ? Constants.Qualities.Maximum : updatedQuality;
        }
    }
}