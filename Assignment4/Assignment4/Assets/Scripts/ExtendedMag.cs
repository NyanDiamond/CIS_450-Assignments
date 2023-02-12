using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendedMag : AttachmentDecorator
{
    public ExtendedMag(WeaponComponent wrap) : base(wrap)
    {
        price = 50;
        recoilMod = 1.2f;
        description = "This weapon has a greater mag size at the cost of recoil control";
    }
}
