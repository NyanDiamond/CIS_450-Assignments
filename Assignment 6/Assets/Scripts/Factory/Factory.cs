using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory
{
     public void SpawnConsumable(string type)
    {
        GameObject objectToSpawn = CreateConsumable(type);
        GameObject.Instantiate(objectToSpawn, new Vector2(GameObject.Find("Player").transform.position.x, 4f), Quaternion.identity);
        objectToSpawn.GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void RemoveScripts(GameObject temp, string type)

    {
        switch (type)
        {
            case "Speed":
                if (temp.GetComponent<SpeedDebuff>() != null)
                    GameObject.DestroyImmediate(temp.GetComponent<SpeedDebuff>(), true);
                if (temp.GetComponent<SpeedBuff>() != null)
                    GameObject.DestroyImmediate(temp.GetComponent<SpeedBuff>(), true);
                break;
            case "Size":
                if (temp.GetComponent<SizeDebuff>() != null)
                    GameObject.DestroyImmediate(temp.GetComponent<SizeDebuff>(), true);
                if (temp.GetComponent<SizeBuff>() != null)
                    GameObject.DestroyImmediate(temp.GetComponent<SizeBuff>(), true);
                break;
            case "Jump":
                if (temp.GetComponent<JumpDebuff>() != null)
                    GameObject.DestroyImmediate(temp.GetComponent<JumpDebuff>(), true);
                if (temp.GetComponent<JumpBuff>() != null)
                    GameObject.DestroyImmediate(temp.GetComponent<JumpBuff>(), true);
                break;
        }
    }
     protected abstract GameObject CreateConsumable(string type);
}
