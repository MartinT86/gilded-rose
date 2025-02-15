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
            backstagePassItem.Quality = backstagePassItem.Quality + 1;
        }
    }
}