using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata.Updaters
{
    public class BrieUpdater
    {
        public static void Update(Item brieItem)
        {
            brieItem.SellIn = brieItem.SellIn - 1;
            brieItem.Quality = CalculateQualityUpdate(brieItem);
        }

        private static int CalculateQualityUpdate(Item brieItem)
        {
            var updateValueBy = brieItem.SellIn >= 0 ? 1 : 2;
            var updatedQuality = brieItem.Quality + updateValueBy;
            return updatedQuality >= 50 ? 50 : updatedQuality;
        }
    }
}