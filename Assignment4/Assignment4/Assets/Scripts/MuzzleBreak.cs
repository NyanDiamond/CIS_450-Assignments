using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleBreak : AttachmentDecorator

{
    public MuzzleBreak(WeaponComponent wrap) : base(wrap)
    {
        price = 50;
        accuracyMod = .9f;
        recoilMod = .7f;
        damageMod = .95f;
        description = "This weapon has much better recoil control with a cost of accuracy and damage";
    }
}
