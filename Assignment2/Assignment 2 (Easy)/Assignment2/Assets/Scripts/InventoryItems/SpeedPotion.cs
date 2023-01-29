using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Assignment 2
//This script inherits the inventory item in order to be a buffing item
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
