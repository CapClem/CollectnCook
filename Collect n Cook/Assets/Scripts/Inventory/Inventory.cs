using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

//This is where the inventory stores it's main functions\\

public class Inventory
{
    private List<ItemBase> currentItems;

    public Inventory()
    {
        currentItems = new List<ItemBase>();
        AddItem(new ItemBase {itemType = ItemBase.ItemType.Apple, itemCount = 1});
        AddItem(new ItemBase {itemType = ItemBase.ItemType.Orange, itemCount = 1});
    }

    public void AddItem(ItemBase item)
    {
        currentItems.Add(item);
    }



    public List<ItemBase> GetItems()
    {
        return currentItems;
    }
}
