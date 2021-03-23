using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

//This is where the inventory stores it's main functions\\

public class Inventory
{
    //Changes the inventory UI to reflect changes to current Inventory
    public event Action OnItemListChanged;
    
    //List to hold all our items
    private List<ItemBase> currentItems;

    public Inventory()
    {
        //Initialise our list
        currentItems = new List<ItemBase>();
        
        //Example on how to add items directly to the inventory. This adds an Apple.
        //AddItem(new ItemBase {itemType = ItemBase.ItemType.Apple, itemCount = 1});
    }

    public void AddItem(ItemBase item)
    {
        //Allows us to pass in "item" to be added to the inventory
        currentItems.Add(item);
        
        //This runs the event to refresh the inventory UI
        OnItemListChanged.Invoke();
    }



    public List<ItemBase> GetItems()
    {
        //Checks our list to see what's in it
        return currentItems;
    }
}
