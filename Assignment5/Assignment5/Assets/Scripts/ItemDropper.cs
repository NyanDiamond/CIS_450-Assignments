using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDropper : MonoBehaviour
{
    [SerializeField] [Tooltip("[common, uncommon, rare, extremly rare]")]GameObject[] prefabs;
    // Start is called before the first frame update
    public GameObject RandomItem(float itemRoll)
    {
        //Debug.Log(itemRoll);
        if(itemRoll<=.50f)
        {
            return prefabs[0];
        }
        else if(itemRoll<.80f)
        {
            return prefabs[1];
        }
        else if(itemRoll<.95f)
        {
            return prefabs[2];
        }
        else
        {
            return prefabs[3];
        }
    }
}
