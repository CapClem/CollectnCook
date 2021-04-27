using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotInteraction : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject UIbackground;
    public GameObject MapCamera;
    public GameObject CookingCamera;
    public GameObject CookBookPanel;
    public GameObject InventoryPanel;
    public bool active;
    public GameObject Player;
    public GameObject Inventory;
    public bool cookingMode;

    void Start()
    {

        UIObject.SetActive(false);
        UIbackground.SetActive(false);
        CookingCamera.SetActive(false);
        CookBookPanel.SetActive(false);
        InventoryPanel.SetActive(false);
    }
    void Update()
    {
        if (active && (Input.GetKeyDown(KeyCode.C)))
        {

            CookingModeActivated();
            
        }

        else if (cookingMode == true && (Input.GetKeyDown(KeyCode.V)))
        {

            CookingModeDeactivate();
            
        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == ("Player"))
        {
            UIObject.SetActive(true);
            UIbackground.SetActive(true);
            active = true;
        }
      
    }
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == ("Player"))
        {
            UIObject.SetActive(false);
            UIbackground.SetActive(false);
            active = false;
        }
    }

    public void CookingModeActivated()
    {
        MapCamera.SetActive(false);

        CookingCamera.SetActive(true);
        CookBookPanel.SetActive(true);
        InventoryPanel.SetActive(true);
        Debug.Log("cooking activated");

        UIObject.SetActive(false);
        UIbackground.SetActive(false);
        Player.SetActive(false);
        Debug.Log("it's all inactive, cook for your life");

        Inventory.SetActive(false);
        cookingMode = true; //make sure when cooking is closed this is set to false
    }

    public void CookingModeDeactivate()
    {
        MapCamera.SetActive(true);

        CookingCamera.SetActive(false);
        CookBookPanel.SetActive(false);
        InventoryPanel.SetActive(false);

        UIObject.SetActive(true);
        UIbackground.SetActive(true);
        Player.SetActive(true);
        Inventory.SetActive(true);
        cookingMode = false;

        //add stuff
        Debug.Log("closed cooking menu");
    }
}
