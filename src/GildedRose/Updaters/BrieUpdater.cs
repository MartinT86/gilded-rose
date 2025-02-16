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
            var updateValueBy = brieItem.SellIn >= 0 ? Constants.Qualities.PreSellByIncrease : Constants.Qualities.PostSellByIncrease;
            var updatedQuality = brieItem.Quality + updateValueBy;
            return updatedQuality >= Constants.Qualities.Maximum ? Constants.Qualities.Maximum : updatedQuality;
        }
    }
}