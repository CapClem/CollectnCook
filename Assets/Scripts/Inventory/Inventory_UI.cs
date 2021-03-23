using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Store the UI functions of the inventory\\

public class Inventory_UI : MonoBehaviour
{
    //Add an inventory to the script
    private Inventory inventory;
    public Transform itemSlot;
    public Transform itemSlotTemplate;
    
    [Tooltip("This should be set to how big you want the inventory to be x, y.")]
    public Vector2 inventoryGridSize;

    //Set the current inventory
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        
        //Subscribe to the event from "Inventory" to refresh the inventory UI when the item is added to inventory
        inventory.OnItemListChanged += OnItemListChanged;
        RefreshInventory();
    }

    private void OnItemListChanged()
    {
        RefreshInventory();
    }
    

    private void RefreshInventory()
    {
        //Check each child in the container eg the inventory grid, destroy them not the template.
        foreach (Transform child in itemSlot)
        {
            //If template skip
            if (child == itemSlotTemplate) continue;
            //Otherwise destroy
            Destroy(child.gameObject);
        }
        Vector2 currentContainer = new Vector2(0, 0);
        
        float itemContainerSize = 50f;
        
        foreach (ItemBase item in inventory.GetItems())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlot).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            
            itemSlotRectTransform.anchoredPosition = new Vector2(currentContainer.x * itemContainerSize, currentContainer.y * itemContainerSize);
            Image image = itemSlotRectTransform.Find("Sprite").GetComponent<Image>();
            image.sprite = item.GetSprite();
            
            //This increases sideways along the item bar
            currentContainer.x++;
            if (currentContainer.x > inventoryGridSize.x) //When it hits the boundary it will go down a line
            {
                currentContainer.x = 0;
                currentContainer.y++;
            }
        }
    }
}
