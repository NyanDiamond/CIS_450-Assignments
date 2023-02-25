using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeDebuff : Consumable
{
    // Start is called before the first frame update
    void Start()
    {
        value = .25f;
        type = "Size";
        isBuff = false;
    }

    // Update is called once per frame
    
}
