using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisItem : MonoBehaviour
{
    public static ThisItem SpawnThisItem(Vector3 position, ItemBase item) //Static function used to spawn items into the world. Choose position and type.
    {
        Transform transform = Instantiate(ItemAssets.Instance.transformSpawnItem, position, Quaternion.identity);
        ThisItem thisItem = transform.GetComponent<ThisItem>();
        thisItem.SetItem(item); //Sets the item to whatever we wanted it to be
        return thisItem; //Returns the final variable
    }
    public ItemBase item;
    private SpriteRenderer spriteRenderer;
    public bool wasPlaced;
    public ItemBase.ItemType itemType;
    public int count;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Start()
    {
        if (wasPlaced)
        {
            item = new ItemBase();
            item.itemType = itemType;
            item.itemCount = count;
        }
    }

    public void SetItem(ItemBase item) //Ask the item
    {
        this.item = item; //Return this item
        spriteRenderer.sprite = item.GetSprite(); //Return sprite
    }

    public ItemBase PickupItem()
    {
        return item;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    
    
}
