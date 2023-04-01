using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overgrown : State
{
    public Overgrown(Pot temp) : base(temp) { }
    public override void Tick()
    {
        return;
    }
    public override void OnClick()
    {
        pot.MinusScore();
        pot.UpdateState(0);
    }
}
