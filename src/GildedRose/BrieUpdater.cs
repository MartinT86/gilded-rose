using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class BrieUpdater
    {
        public static Item Update(Item brieItem)
        {
            return new Item
            {
                Name = brieItem.Name,
                SellIn = brieItem.SellIn - 1,
                Quality = brieItem.Quality + CalculateQualityUpdate(brieItem)
            };
        }

        private static int CalculateQualityUpdate(Item brieItem)
        {
            return brieItem.SellIn > 0 ? 1 : 2;
        }
    }
}