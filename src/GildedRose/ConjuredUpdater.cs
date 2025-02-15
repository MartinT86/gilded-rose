using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class ConjuredUpdater
    {
        public static void Update(Item defaultItem)
        {
            defaultItem.SellIn = defaultItem.SellIn - 1;
            defaultItem.Quality = CalculateQualityUpdate(defaultItem);
        }

        private static int CalculateQualityUpdate(Item defaultItem)
        {
            var updateValueBy = defaultItem.SellIn < 0 ? 4 : 2;
            int updatedValue = defaultItem.Quality - updateValueBy;
            return updatedValue < 0 ? 0 : updatedValue;
        }
    }
}