using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
