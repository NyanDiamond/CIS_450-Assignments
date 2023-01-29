using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Assignment 2
//This script implements the usable interface to heal
public class HealthUse : Usable
{
    public void Use(int value)
    {
        //Interact with interface to increase a health value
        Debug.Log("Heal for " + value);
        GameObject.FindObjectOfType<InventorySimulator>().ChangeHP(value);
    }
}
