using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : State
{
    public Growing(Pot temp) : base(temp) { }
    public override void Tick()
    {
        float temp = Random.Range(0, 1f);
        if (temp < 0.4f)
        {
            pot.UpdateState(2);
        }
    }
    public override void OnClick()
    {
        return;
    }
}
