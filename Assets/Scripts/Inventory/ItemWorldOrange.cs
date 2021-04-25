using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorldOrange : MonoBehaviour
{

    public static ItemWorldOrange SpawnItemWorldOrange(Vector3 position, Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.orange3D, position, Quaternion.identity);

        ItemWorldOrange itemWorldOrange = transform.GetComponent<ItemWorldOrange>();
        itemWorldOrange.SetItem(item);
        return itemWorldOrange;
    }


    private Item item;
    public Sprite _Image;

    public Sprite OrangeSpriteImage()
    {
         return _Image;
    }

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
