using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deselect : MonoBehaviour
{
    public void DeselectIngre()
    {
        this.GetComponent<Image>().sprite = null;
    }
}
