using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDebuff : Consumable
{
    // Start is called before the first frame update
    void Start()
    {
        value = .75f;
        type = "Speed";
        isBuff = false;
    }

    // Update is called once per frame
    
}
