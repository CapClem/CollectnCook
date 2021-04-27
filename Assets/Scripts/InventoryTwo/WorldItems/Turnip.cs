using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnip : MonoBehaviour, IInventoryItem
{
    public string Name
    {
        get
        {
            return "Turnip";
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
