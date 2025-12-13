using CS_Learning_Journey.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Learning_Journey.Tests
{
    
   public class DictTest
    {
        public void inventoryDictTest()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Inventory Testing!!-- will be removed by tomorrow.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Item newItem = new Item();
            newItem.ItemName = "Sword of Destiny";
            newItem.ItemDescription = "A legendary sword with immense power.";
            newItem.ItemType = "Weapon";

            Inventory inventory = new Inventory();
            Player player = new Player(0, 1);
            player.inventory.AddItem(newItem);

            if (player.inventory.items.ContainsKey("Sword of Destiny"))
            {
                Console.WriteLine("Sword of Destiny successfully added to inventory:");
                var myItem = player.inventory.items["Sword of Destiny"];
                Console.WriteLine($"Name: {myItem.ItemName} \nDescription: {myItem.ItemDescription} \nItem Type: {myItem.ItemType}");
            }
            else
                Console.WriteLine("Failed to add item to inventory.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press Any Screen to remove this testing screen");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

    }

    
    
}
