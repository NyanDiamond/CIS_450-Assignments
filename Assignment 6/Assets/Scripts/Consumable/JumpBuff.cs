using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBuff : Consumable
{
    // Start is called before the first frame update
    void Start()
    {
        value = 2;
        type = "Jump";
        isBuff = true;
    }

}
