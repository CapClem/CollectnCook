using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return "Orange";
        }
    }

    public Sprite _Image;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void Onpickup()
    {
        gameObject.SetActive(false);
    }
}
