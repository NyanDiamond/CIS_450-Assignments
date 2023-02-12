using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR : WeaponComponent
{
    float price, damage, accuracy, recoil;
    string description;

    public AR()
    {
        price = 300f;
        damage = 50f;
        accuracy = 600f;
        recoil = 700;
        description = "This fully automatic assault rifle is a beast in close range combat.\nWith a skilled combatant it can also suffice at mid range but starts to struggle at long range without good attachments";
    }
    public float CalculateAccuracy()
    {
        return accuracy;
    }

    public float CalculateDamage()
    {
        return damage;
    }

    public float CalculatePrice()
    {
        return price;
    }

    public float CalculateRecoil()
    {
        return recoil;
    }

    public string Description()
    {
        return description;
    }
}
