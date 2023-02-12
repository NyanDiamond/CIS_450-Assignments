using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface WeaponComponent
{
    public float CalculateDamage();
    public float CalculateAccuracy();
    public float CalculateRecoil();
    public float CalculatePrice();
    public string Description();
    

   
}
