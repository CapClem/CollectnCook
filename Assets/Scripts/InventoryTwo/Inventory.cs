using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryUIMessage;

    private const int SLOTS = 21;

    private List<IInventoryItem> mItems = new List<IInventoryItem>();

    public event EventHandler<InventoryEventArgs> ItemAdded;

    void Start()
    {
        inventoryUIMessage.SetActive(false);
    }

    public void AddItem(IInventoryItem item)
    {
        if (mItems.Count < SLOTS)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();

            if (collider.enabled)
            {
                collider.enabled = false;
                mItems.Add(item);
                item.Onpickup();

                if (ItemAdded != null)
                {
                    ItemAdded(this, new InventoryEventArgs(item));
                }
            }
        }

        else if(mItems.Count >= SLOTS)
        {
            inventoryUIMessage.SetActive(true);
            //Debug.Log("Inventory Is Full!");
        }
    }
}
