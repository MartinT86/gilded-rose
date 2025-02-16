using System.Collections.Generic;
using System.Linq;
using GildedRoseKata.Updaters;

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
            Items.Where(IsBrie).ToList().ForEach(BrieUpdater.Update);
            Items.Where(IsBackstagePass).ToList().ForEach(BackstagePassUpdater.Update);
            Items.Where(IsSulfuras).ToList().ForEach(SulfurasUpdater.Update);
            Items.Where(IsConjured).ToList().ForEach(ConjuredUpdater.Update);
            Items.Where(IsNormal).ToList().ForEach(DefaultUpdater.Update);
        }

        private bool IsBrie(Item item)
        {
            return item.Name == "Aged Brie";
        }

        private bool IsBackstagePass(Item item)
        {
            return item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        private bool IsSulfuras(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        private bool IsConjured(Item item)
        {
            return item.Name == "Conjured Mana Cake";
        }

        private bool IsNormal(Item item)
        {
            return item.Name != "Aged Brie"
                && item.Name != "Backstage passes to a TAFKAL80ETC concert"
                && item.Name != "Sulfuras, Hand of Ragnaros"
                && item.Name != "Conjured Mana Cake";
        }
    }
}
