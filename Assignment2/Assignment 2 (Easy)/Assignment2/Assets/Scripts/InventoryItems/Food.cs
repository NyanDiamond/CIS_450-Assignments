using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : InventoryItem
{
    private void Start()
    {
        useType = new HealthUse();
        value = 15;
    }
    protected override void Display()
    {
        Debug.Log("Your health regenerates a bit");
    }
}
