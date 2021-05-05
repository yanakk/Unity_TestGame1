﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/New Item")]
public class Item : ScriptableObject
{
    public int itemID;
    public string itemName;
    public Sprite itemImage;
    public int itemHeld;
    public bool isEquip = true;
    [TextArea]
    public string itemInfo;
}
