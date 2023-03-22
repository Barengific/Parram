using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "item/Create New Item")]
public class ItemObject : ScriptableObject
{
    public int id;
    public string name;
    public string description;
    public Sprite icon;
    public int time;
    public int value;

}
