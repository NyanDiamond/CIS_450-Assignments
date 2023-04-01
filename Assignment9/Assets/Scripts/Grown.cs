using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grown : State
{
    public Grown(Pot temp) : base(temp) { }
    public override void Tick()
    {
        float temp = Random.Range(0, 1f);
        if (temp < 0.35f)
        {
            pot.UpdateState(3);
        }
    }
    public override void OnClick()
    {
        pot.AddScore();
        pot.UpdateState(0);
    }
}
