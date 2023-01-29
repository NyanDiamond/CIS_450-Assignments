using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Assignment 2
//This script inherits the inventory item in order to be a medium healing item
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
