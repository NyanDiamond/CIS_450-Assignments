using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Assignment 2
//This script inherits the inventory item in order to be a shield restoration item
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
