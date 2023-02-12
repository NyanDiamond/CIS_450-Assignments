using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttachmentDecorator : WeaponComponent
{
    protected float price = 0;
    protected float damageMod = 1;
    protected float accuracyMod = 1;
    protected float recoilMod = 1;
    protected string description = "";
    protected WeaponComponent wrappedObject;

    public AttachmentDecorator(WeaponComponent wrap)
    {
        wrappedObject = wrap;
    }

    public float CalculateAccuracy()
    {
        return accuracyMod * wrappedObject.CalculateAccuracy();
    }

    public float CalculateDamage()
    {
        return damageMod * wrappedObject.CalculateDamage();
    }

    public float CalculatePrice()
    {
        return price + wrappedObject.CalculatePrice();
    }

    public float CalculateRecoil()
    {
        return recoilMod * wrappedObject.CalculateRecoil();
    }

    public string Description()
    {
        return wrappedObject.Description() + "\n" + description;
    }
}
