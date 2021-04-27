using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySetActive : MonoBehaviour
{
    public GameObject setThisActive;
    public PotInteraction cookingModeScript;

    void Start()
    {
        if (setThisActive == true)
        {
            setThisActive.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && cookingModeScript.cookingMode == false)
        {
            //check if you are in cooking mode and if cooking mode = true, return
            setThisActive.SetActive(true);
        }

        else if (Input.GetKeyDown(KeyCode.O)) 
        {
            setThisActive.SetActive(false);
        }
    }
}
