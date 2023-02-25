using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : Consumable
{
    // Start is called before the first frame update
    void Start()
    {
        value = .75f;
        type = "Speed";
        isBuff = true;
    }

    // Update is called once per frame
    
}
