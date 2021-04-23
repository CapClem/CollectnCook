using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCrafting : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject UIbackground;

   

    public float radius = 2f;
    void Start()
    {
        
        UIObject.SetActive(false);
        UIbackground.SetActive(false);
    }
   
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == ("Player"))
        {
            UIObject.SetActive(true);
            UIbackground.SetActive(true);
        }
           
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == ("Player"))
        {
            UIObject.SetActive(false);
            UIbackground.SetActive(false);
        }
    }

}
