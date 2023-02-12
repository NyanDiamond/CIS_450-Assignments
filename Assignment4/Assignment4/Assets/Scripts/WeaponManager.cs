using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{
    private WeaponComponent weapon;
    [SerializeField] Text priceText, accuracyText, damageText, recoilText, descriptionText;
    private int[] attachments = { 0, 0, 0 };

    private void Start()
    {
        weapon = new AR();
        UpdateText();
    }

    private void UpdateText()
    {
        priceText.text = "Price: $" + weapon.CalculatePrice().ToString("F2");
        accuracyText.text = "Accuracy(1000=no aim cone): " + weapon.CalculateAccuracy().ToString("F2");
        damageText.text = "Damage: " +  weapon.CalculateDamage().ToString("F2");
        recoilText.text = "Recoil(0 = no recoil): " + weapon.CalculateRecoil().ToString("F2");
        descriptionText.text = weapon.Description();
    }

    private void GenerateWeapon()
    {
        weapon = new AR();
        switch(attachments[0])
        {
            default:
                break;
            case 1:
                weapon = new HoloSight(weapon);
                break;
            case 2:
                weapon = new ACOG(weapon);
                break;
        }
        switch(attachments[1])
        {
            default:
                break;
            case 1:
                weapon = new ExtendedMag(weapon);
                break;
            case 2:
                weapon = new QuickMag(weapon);
                break;
        }
        switch(attachments[2])
        {
            default:
                break;
            case 1:
                weapon = new MuzzleBreak(weapon);
                break;
            case 2:
                weapon = new Silencer(weapon);
                break;
        }
        UpdateText();
    }

    public void AddAttachment(Attachment at)
    {
        attachments[at.attachmentSlotID] = at.attachmentID;
        GenerateWeapon();
    }

    public void ResetAttachments()
    {
        for (int i =0; i<attachments.Length; i++)
        {
            attachments[i] = 0;
        }
        GenerateWeapon();
    }

}
