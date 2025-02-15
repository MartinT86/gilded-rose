﻿using System.Collections.Generic;
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

            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" 
                    && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert"
                    && Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[i].Quality > 0)
                        {
                            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Items[i].Quality = Items[i].Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;

                            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                            {
                                if (Items[i].SellIn < 11)
                                {
                                    if (Items[i].Quality < 50)
                                    {
                                        Items[i].Quality = Items[i].Quality + 1;
                                    }
                                }

                                if (Items[i].SellIn < 6)
                                {
                                    if (Items[i].Quality < 50)
                                    {
                                        Items[i].Quality = Items[i].Quality + 1;
                                    }
                                }
                            }
                        }
                    }

                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].SellIn = Items[i].SellIn - 1;
                    }

                    if (Items[i].SellIn < 0)
                    {
                        if (Items[i].Name != "Aged Brie")
                        {
                            if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                            {
                                if (Items[i].Quality > 0)
                                {
                                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                    {
                                        Items[i].Quality = Items[i].Quality - 1;
                                    }
                                }
                            }
                            else
                            {
                                Items[i].Quality = Items[i].Quality - Items[i].Quality;
                            }
                        }
                        else
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
