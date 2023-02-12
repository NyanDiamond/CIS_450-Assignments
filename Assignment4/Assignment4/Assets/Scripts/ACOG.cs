using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACOG : AttachmentDecorator

{
    public ACOG(WeaponComponent wrap):base(wrap)
    {
        price = 100;
        accuracyMod = 2.0f;
        recoilMod = 1.4f;
        description = "This weapon has a 4x zoom when aiming down sights at the cost of recoil control and a big price";
    }
}
