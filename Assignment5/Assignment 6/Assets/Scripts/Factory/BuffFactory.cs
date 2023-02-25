using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffFactory : Factory
{
    protected override GameObject CreateConsumable(string type)
    {
        GameObject temp = null;
        switch (type)
        {
            case "Speed":
                temp = Resources.Load<GameObject>("Speed");
                RemoveScripts(temp, type);
                temp.AddComponent<SpeedBuff>();
                break;
            case "Size":
                temp = Resources.Load<GameObject>("Size");
                RemoveScripts(temp, type);
                temp.AddComponent<SizeBuff>();
                break;
            case "Jump":
                temp = Resources.Load<GameObject>("Jump");
                RemoveScripts(temp, type);
                temp.AddComponent<JumpBuff>();
                break;
        }
        temp.GetComponent<SpriteRenderer>().color = Color.green;
        return temp;
    }
}
