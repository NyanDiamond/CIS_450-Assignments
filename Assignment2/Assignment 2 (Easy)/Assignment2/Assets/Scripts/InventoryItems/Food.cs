using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Assignment 2
//This script inherits the inventory item in order to be a small healing item
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
