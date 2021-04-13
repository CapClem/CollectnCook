using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Item", menuName = "Item")]
public class ItemHandler : ScriptableObject
{
    public new string name;
    public string desc;

    public Sprite icon;

    public int Item_ID;

}
