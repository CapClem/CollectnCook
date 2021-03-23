using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using Random = UnityEngine.Random;

//This is simply for adding the inventory to the related player\\
//TRY TO USE THIS TO INFLUENCE HOW YOUR PLAYER SHOULD WORK\\

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private Inventory_UI inventoryUI; //LINK THIS TO THE PLAYER UI
    
    //This tells our player script it has an inventory
    private Inventory inventory;
    private bool isActive;
    private bool isCoroutineRunning;
    
    public void Awake()
    {
        //This is how we initialise the inventory - In other words this gives it to our player
        inventory = new Inventory();
        inventoryUI.SetInventory(inventory);
        isActive = false;
        inventoryUI.gameObject.SetActive(false);

        //So we ask to spawn the item with SpawnThisItem, give it a position, tell it what item and how much. (EDITABLE)
        ThisItem.SpawnThisItem(new Vector3(2,0,0), new ItemBase {itemType = ItemBase.ItemType.Apple, itemCount = 1});
        ThisItem.SpawnThisItem(new Vector3(0,2,0), new ItemBase {itemType = ItemBase.ItemType.Orange, itemCount = 1});
        ThisItem.SpawnThisItem(new Vector3(3,0,0), new ItemBase {itemType = ItemBase.ItemType.Orange, itemCount = 1});
        ThisItem.SpawnThisItem(new Vector3(0,3,0), new ItemBase {itemType = ItemBase.ItemType.Orange, itemCount = 1});
        //Spawn multiple instead randomly
        //for (int i = 0; i < 10; i++)
        //{
        //   Vector3 spawnLocation = new Vector3(Random.Range(1, 10), 1, Random.Range(1, 10));
        //   ThisItem.SpawnThisItem(spawnLocation, new ItemBase {itemType = ItemBase.ItemType.Apple, itemCount = 1});
        //}
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.I) && isCoroutineRunning == false && isActive == false)
        {
            isActive = true;
            StartCoroutine(InventoryDelay());
        }
        if (Input.GetKeyDown(KeyCode.I) && isCoroutineRunning == false && isActive == true)
        {
            isActive = false;
            StartCoroutine(InventoryDelay());
        }
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
    
    
    IEnumerator InventoryDelay()
    {
        isCoroutineRunning = true;
        inventoryUI.gameObject.SetActive(isActive);
        yield return new WaitForSeconds(.2f);
        isCoroutineRunning = false;
    }
    
}
