using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            Items.Where(x => x.Name == "Aged Brie").ToList().ForEach(x => BrieUpdater.Update(x));
            Items.Where(x => x.Name == "Backstage passes to a TAFKAL80ETC concert")
                .ToList().ForEach(x => BackstagePassUpdater.Update(x));
            Items.Where(x => x.Name == "Sulfuras, Hand of Ragnaros")
                .ToList().ForEach(x => SulfurasUpdater.Update(x));
            Items.Where(x => x.Name == "Conjured Mana Cake")
                .ToList().ForEach(x => ConjuredUpdater.Update(x));
            Items.Where(x => x.Name != "Aged Brie"
                && x.Name != "Backstage passes to a TAFKAL80ETC concert"
                && x.Name != "Sulfuras, Hand of Ragnaros"
                && x.Name != "Conjured Mana Cake")
                .ToList().ForEach(x => DefaultUpdater.Update(x));
        }
    }
}
