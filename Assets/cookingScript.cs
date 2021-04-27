using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookingScript : MonoBehaviour
{

    public GameObject MapCamera;
    public GameObject CookingCamera;
    public GameObject CookBookPanel;
    public GameObject InventoryPanel;
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        CookingCamera.SetActive(false);
        CookBookPanel.SetActive(false);
        InventoryPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            MapCamera.SetActive(false);
            CookingCamera.SetActive(true);
            CookBookPanel.SetActive(true);
            InventoryPanel.SetActive(true);
            Debug.Log ("cooking activated");
        }
    }
}
