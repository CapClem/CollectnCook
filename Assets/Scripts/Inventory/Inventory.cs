using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public event EventHandler OnItemListChanged;

    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        //this will directly add items in the inventory panel and during pick up it will update the list

        AddItem(new Item { itemType = Item.ItemType.Apple, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Orange, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Banana, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Mushroom, amount = 1 });

    }

    public void AddItem(Item item)
    { 
        //on player trigger enter this will add the item inthe inventory panel
        itemList.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
