using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : InventoryItem
{
    private void Start()
    {
        useType = new BuffUse();
        value = 1;
    }
    protected override void Display()
    {
        Debug.Log("Your Speed has increased");
    }
}
