using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is intended to store information about our items\\

public class ItemBase
{
    public enum ItemType
    {
        //This enum holds what type of item (EDITABLE)
        Apple,
        Orange,
    }

    public ItemType itemType;
    public int itemCount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            //This switch assigns a sprite to the item (EDITABLE)
            case ItemType.Apple: return ItemAssets.Instance.appleSprite;
            case ItemType.Orange: return ItemAssets.Instance.orangeSprite;
        }
    }


}
