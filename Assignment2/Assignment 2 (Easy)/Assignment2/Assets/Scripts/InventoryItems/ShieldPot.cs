using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPot : InventoryItem
{
    private void Start()
    {
        useType = new ShieldUse();
        value = 25;
    }
    protected override void Display()
    {
        Debug.Log("Your shield regenerates");
    }
}
