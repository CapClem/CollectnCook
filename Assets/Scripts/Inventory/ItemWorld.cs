using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    //the actual items that will be spawned to the game and will be called by  SpawnItemWorld in the player movement script

    public static ItemWorld SpawnItemWorldApple(Vector3 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.apple3D, position, Quaternion.identity);

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItem(item);
        return itemWorld;
    }

    public static ItemWorld SpawnItemWorldBanana(Vector3 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.banana3D, position, Quaternion.identity);

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItem(item);
        return itemWorld;
    }

    public static ItemWorld SpawnItemWorldMushroom(Vector3 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.mushroom3D, position, Quaternion.identity);

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.SetItem(item);
        return itemWorld;
    }

    private Item item;

    //private MeshFilter prefab3D;

    private void Awake()
    {
        //prefab3D = GetComponent<MeshFilter>();
    }

    public void SetItem(Item item)
    {
        this.item = item;
        
        //prefab3D.mesh = item.GetSprite();
    }

    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
