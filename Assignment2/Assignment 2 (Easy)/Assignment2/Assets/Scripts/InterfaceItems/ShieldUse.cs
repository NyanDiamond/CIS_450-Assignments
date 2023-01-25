using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldUse : Usable
{
    public void Use(int value)
    {
        //Interact with interface to increase a shield value
        Debug.Log("Shield for " + value);
        GameObject.FindObjectOfType<InventorySimulator>().ChangeShield(value);
    }
}
