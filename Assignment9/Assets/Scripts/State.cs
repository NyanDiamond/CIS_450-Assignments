using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    protected Pot pot;
    public State(Pot temp)
    {
        pot = temp;
    }

    public abstract void Tick();

    public abstract void OnClick();
}
