using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty : State
{
    public Empty(Pot temp) : base(temp) { }
    public override void Tick()
    {
        float temp = Random.Range(0, 1f);
        if(temp<0.25f)
        {
            pot.UpdateState(1);
        }
    }
    public override void OnClick()
    {
        pot.UpdateState(1);
    }

}
