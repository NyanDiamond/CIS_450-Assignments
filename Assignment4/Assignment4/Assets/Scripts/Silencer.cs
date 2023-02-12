using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silencer : AttachmentDecorator
{
    public Silencer(WeaponComponent wrap) : base(wrap)
    {
        price = 125;
        damageMod = .75f;
        description = "This weapon is now silent at a premium price tag and at a cost of a lot of damage";
    }
}
