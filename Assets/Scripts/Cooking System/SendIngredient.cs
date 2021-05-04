using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendIngredient : MonoBehaviour
{
    public GameObject slotchild;
    public Sprite sprite ;
    public GameObject booklink;

    void Start()
    {
        booklink = GameObject.FindGameObjectWithTag("cookbook");
    }

    public void sendIngredient()
    {
        sprite = slotchild.GetComponent<Image>().sprite;

        booklink.transform.GetChild(0).GetComponent<Image>().sprite = sprite;
       
    }
}
