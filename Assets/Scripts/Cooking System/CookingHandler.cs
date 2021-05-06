using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CookingHandler : MonoBehaviour
{
    public GameObject[] cSlot;
    public GameObject result;
    public Sprite[] foodResult;
    bool cookedFood = false;
    public GameObject resetButt;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cookedFood == true)
        {
            resetButt.SetActive(false);
        }
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

    public void ComboList()
    { 
            //there's clearly an easier way to do this
            if (cSlot[0].GetComponent<Image>().sprite.name == "pumpkin" |
                cSlot[0].GetComponent<Image>().sprite.name == "turnip" |
                cSlot[0].GetComponent<Image>().sprite.name == "mushroom")
            {
                if (cSlot[1].GetComponent<Image>().sprite.name == "pumpkin" |
                    cSlot[1].GetComponent<Image>().sprite.name == "turnip" |
                    cSlot[1].GetComponent<Image>().sprite.name == "mushroom")
                {
                    if (cSlot[2].GetComponent<Image>().sprite.name == "pumpkin" |
                        cSlot[2].GetComponent<Image>().sprite.name == "turnip" |
                        cSlot[2].GetComponent<Image>().sprite.name == "mushroom")
                    {
                        Debug.Log("Cooked Stew");
                        result.GetComponent<Image>().sprite = foodResult[1];
                        cookedFood = true;
                        Debug.Log(result.GetComponent<Image>().sprite);
                }
                }
            }
            if
               (cSlot[0].GetComponent<Image>().sprite.name == "orange" |
                cSlot[0].GetComponent<Image>().sprite.name == "banana" |
                cSlot[0].GetComponent<Image>().sprite.name == "apple")
            {
                if (cSlot[1].GetComponent<Image>().sprite.name == "orange" |
                    cSlot[1].GetComponent<Image>().sprite.name == "banana" |
                    cSlot[1].GetComponent<Image>().sprite.name == "apple")
                {
                    if (cSlot[2].GetComponent<Image>().sprite.name == "orange" |
                        cSlot[2].GetComponent<Image>().sprite.name == "banana" |
                        cSlot[2].GetComponent<Image>().sprite.name == "apple")
                    {
                        Debug.Log("Salad");
                        result.GetComponent<Image>().sprite = foodResult[2];
                        cookedFood = true;

                    }
                }
            }
            else if (cookedFood == false)
            {
                 result.GetComponent<Image>().sprite = foodResult[0];
            }

    }

    public void RetryCook()
    {
       result.GetComponent<Image>().sprite = null;
    }

    public void Refresh()
    {
        SceneManager.LoadScene(1);
    }
}

