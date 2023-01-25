using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUse : Usable
{
    public void Use(int value)
    {
        //Interact with interface to increase a health value
        Debug.Log("Heal for " + value);
        GameObject.FindObjectOfType<InventorySimulator>().ChangeHP(value);
    }
}
