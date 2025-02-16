using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata.Updaters
{
    public class SulfurasUpdater
    {
        public static void Update(Item sulfurasItem)
        {
            sulfurasItem.Quality = Constants.Qualities.Legendary;
        }
    }
}