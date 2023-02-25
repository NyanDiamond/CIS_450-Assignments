using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeBuff : Consumable
{
    // Start is called before the first frame update
    void Start()
    {
        value = .25f;
        type = "Size";
        isBuff = true;
    }

    // Update is called once per frame
    
}
