using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Josh Bonovich
//Assignment 2
//This script implements the usable interface to buff (using a case value)
public class BuffUse : Usable
{
    public void Use(int value)
    {
        switch (value)
        {
            case 1:
                Debug.Log("buff Speed used");
                GameObject.FindObjectOfType<InventorySimulator>().ChangeSpeedBuff(true);
                break;
        }


    }
}
