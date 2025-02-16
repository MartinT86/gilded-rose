using System;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int requiredDayCount = int.Parse(args[0]);
            Console.WriteLine("OMGHAI!");

            var itemStore = new ItemStore();
            var Items = itemStore.GetItems();

            var app = new GildedRose(Items);

            for (var i = 0; i <= requiredDayCount; i++)
            {
                PrintDay(Items, i);
                app.UpdateQuality();
            }
        }

        private static void PrintDay(System.Collections.Generic.IList<Item> Items, int dayNumber)
        {
            Console.WriteLine("-------- day " + dayNumber + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < Items.Count; j++)
            {
                System.Console.WriteLine($"{Items[j].Name}, {Items[j].SellIn}, {Items[j].Quality}");
            }
            Console.WriteLine("");
        }
    }
}
