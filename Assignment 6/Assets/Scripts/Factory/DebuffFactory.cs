using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffFactory : Factory
{
    protected override GameObject CreateConsumable(string type)
    {
        GameObject temp = null;
        switch (type)
        {
            case "Speed":
                temp = Resources.Load<GameObject>("Speed");
                RemoveScripts(temp, type);
                temp.AddComponent<SpeedDebuff>();
                

                break;
            case "Size":
                temp = Resources.Load<GameObject>("Size");
                RemoveScripts(temp, type);
                temp.AddComponent<SizeDebuff>();
                break;
            case "Jump":
                temp = Resources.Load<GameObject>("Jump");
                RemoveScripts(temp, type);
                temp.AddComponent<JumpDebuff>();
                break;
        }
        temp.GetComponent<SpriteRenderer>().color = Color.red;
        return temp;
    }
}

    
