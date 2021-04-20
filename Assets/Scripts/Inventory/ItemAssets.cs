using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is for storing anything related to the inventory otherwise not stated. eg. sprites\\

public class ItemAssets : MonoBehaviour
{
    //Make this a singleton (DO NOT EDIT)
    public static ItemAssets Instance { get; private set; }
    private void Awake()
    {
        Instance = this;

        carrotSprite = Resources.Load<Sprite>("Sprites/image0.png");
    }
    //Make this a singleton (DO NOT EDIT)

    public Transform transformSpawnItem;
    
    //All you need to add is the sprites to here (EDITABLE)
    public Sprite appleSprite;
    public Sprite orangeSprite;
    public Sprite carrotSprite;
}
