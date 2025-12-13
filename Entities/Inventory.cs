using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Learning_Journey.Entities
{
    public class Inventory
    {
        public Dictionary<string, Item> items = new Dictionary<string, Item>();

        public void AddItem(Item newitem)
        {
            items.Add(newitem.ItemName, newitem);
        }

        
    }

    
}
