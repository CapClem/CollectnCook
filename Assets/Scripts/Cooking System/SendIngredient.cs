using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendIngredient : MonoBehaviour
{
    public GameObject slotchild;
    public Sprite spriteSend ;
    public GameObject booklink;
    //int count = 0;

    void Start()
    {
        booklink = GameObject.FindGameObjectWithTag("cookbook");
    }

    public void sendIngredient()
    {

        spriteSend = slotchild.GetComponent<Image>().sprite;

        GameObject[] e = booklink.GetComponent<CookingHandler>().cSlot;

        //what this piece does is that it checks a spot within the cSlots and places an ingredient there


        foreach (GameObject a in e)
        {
            if (a.GetComponent<Image>().sprite == null)
            {
                a.GetComponent<Image>().sprite = spriteSend;
                Debug.Log(a.GetComponent<Image>().sprite);
                break;
            }
           
        }

        slotchild.GetComponent<Image>().enabled = false;
        this.GetComponent<Button>().enabled = false;
    }
}
//This code down the bottom was my first attempt at the if statement, something went wrong
//if (e.GetComponent<Image>().sprite != null)
//{

//    //booklink.transform.GetChild(count).GetComponent<Image>().sprite = spriteSend;
//    //e.GetComponent<Image>().sprite = spriteSend;
//    Debug.Log(e + " has recieved image " + spriteSend);
//   // break;

//}
//else if (e.GetComponent<Image>().sprite == null)
//{
//    e.GetComponent<Image>().sprite = spriteSend;
//    //booklink.transform.GetChild().GetComponent<Image>().sprite = spriteSend;
//    Debug.Log(e + " DID NOT recieved image " + spriteSend);

//   //break;
//}
