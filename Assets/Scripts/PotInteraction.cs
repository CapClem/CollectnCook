using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotInteraction : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject UIbackground;

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
