using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoloSight : AttachmentDecorator


{
    public HoloSight(WeaponComponent wrap) : base(wrap)
    {
        price = 75;
        accuracyMod = 1.5f;
        recoilMod = 1.05f;
        description = "This weapon has a 2x zoom when aiming down sights with a slight cost to recoil control";
    }
}
