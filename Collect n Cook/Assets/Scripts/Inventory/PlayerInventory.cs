using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is simply for adding the inventory to the related player\\
//TRY TO USE THIS TO INFLUENCE HOW YOUR PLAYER SHOULD WORK\\

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private Inventory_UI inventoryUI; //LINK THIS TO THE PLAYER UI
    
    //This tells our player script it has an inventory
    private Inventory inventory;

    public void Awake()
    {
        //This is how we initialise the inventory - In other words this gives it to our player
        inventory = new Inventory();
        inventoryUI.SetInventory(inventory);

        //So we ask to spawn the item with SpawnThisItem, give it a position, tell it what item and how much.
        ThisItem.SpawnThisItem(new Vector3(10, 10), new ItemBase {itemType = ItemBase.ItemType.Apple, itemCount = 1});

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ThisItem thisItem = other.GetComponent<ThisItem>(); //See if we can get the item from get component
        if (thisItem != null) //If not null this is an item
        {
            inventory.AddItem(thisItem.PickupItem());
            thisItem.DestroySelf();
        }
    }
}
