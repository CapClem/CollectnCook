using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookingHandler : MonoBehaviour
{
    public GameObject cSlot1;
    public GameObject cSlot2;
    public GameObject cSlot3;
    public GameObject result;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CookingPanel_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform cookingPanel = transform.Find("CookBookPanel");
        foreach(Transform cSlot in cookingPanel)
        {
            Image image = cSlot.GetChild(0).GetComponent<Image>();

            if (!image.enabled)
            {
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }
        }
    }

    public void addIngre()
    {
        //cSlot1.GetComponent<Image>().sprite = 
        //Reference to the slot
        //reference to the object I'm clicking on
        //Set the slot image to object image
        Debug.Log(this.gameObject);
    }
}

