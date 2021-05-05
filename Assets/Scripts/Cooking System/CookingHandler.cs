using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookingHandler : MonoBehaviour
{
    public GameObject[] cSlot;
    public GameObject result;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void CookingPanel_ItemAdded(object sender, InventoryEventArgs e)
    //{
    //    Transform cookingPanel = transform.Find("CookBookPanel");
    //    foreach(Transform cSlot in cookingPanel)
    //    {
    //        Image image = cSlot.GetChild(0).GetComponent<Image>();

    //        if (!image.enabled)
    //        {
    //            image.enabled = true;
    //            image.sprite = e.Item.Image;

    //            break;
    //        }
    //    }
    //}

    public void ComboList(/*Sprite sprite*/)
    {
        if (cSlot[0].GetComponent<Image>().sprite.name == "pumpkin" |
            cSlot[1].GetComponent<Image>().sprite.name == "turnip" |
            cSlot[2].GetComponent<Image>().sprite.name == "mushroom")
        {
            print("it works");
        }
        else
        {
            print("something wrong");
        }
    }
}

