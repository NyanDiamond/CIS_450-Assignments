using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPot : InventoryItem
{
    private void Start()
    {
        useType = new HealthUse();
        value = 25;
    }
    protected override void Display()
    {
        Debug.Log("Your health regenerates");
    }
}
