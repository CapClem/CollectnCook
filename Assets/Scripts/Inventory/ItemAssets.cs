using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{

    //items get declared in here 

    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    

    //public Transform ItemWorldpf;
    

    public Sprite appleSprite;
    public Sprite orangeSprite;
    public Sprite bananaSprite;
    public Sprite mushroomSprite;

    public Transform apple3D;
    public Transform orange3D;
    public Transform banana3D;
    public Transform mushroom3D;

}
