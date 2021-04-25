using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Apple,
        Orange,
        Banana,
        Mushroom,       
    }

    public enum ItemType3D
    {
        Apple3D,
        Orange3D,
        Banana3D,
        Mushroom3D,
    }

    public ItemType itemType;

    public ItemType3D itemType3D;

    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:

            case ItemType.Apple:    return ItemAssets.Instance.appleSprite;

            case ItemType.Orange:   return ItemAssets.Instance.orangeSprite;

            case ItemType.Banana:   return ItemAssets.Instance.bananaSprite;

            case ItemType.Mushroom: return ItemAssets.Instance.mushroomSprite;
        }
    }

    /*
    public Transform Get3DObject()
    {
        switch (itemType3D)
        {
            default:
            case ItemType3D.Apple3D:    return ItemAssets.Instance.apple3D;

            case ItemType3D.Orange3D:   return ItemAssets.Instance.orange3D;

            case ItemType3D.Banana3D:   return ItemAssets.Instance.banana3D;

            case ItemType3D.Mushroom3D: return ItemAssets.Instance.mushroom3D;
        }
    }

    public bool IsStackable()
    {
        switch(itemType)
        {
            default:
            case ItemType.Apple:
                return true;

            case ItemType.Orange:
                return true;

            case ItemType.Banana:
                return true;

            case ItemType.Mushroom:
                return true;
        }
    }*/
}
