using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySimulator : MonoBehaviour
{
    public Text healthText;
    public Text shieldText;
    public Text speedBuffText;
    private int health = 100;
    private int shield = 100;
    // Start is called before the first frame update
    public void ChangeHP(int value)
    {
        health += value;
        health = Mathf.Clamp(health, 0, 100);
        healthText.text = "Health: " + health + "/" + 100;
    }

    public void ChangeShield(int value)
    {
        shield += value;
        shield = Mathf.Clamp(shield, 0, 100);
        shieldText.text = "Shield: " + shield + "/" + 100;
    }

    public void ChangeSpeedBuff(bool value)
    {
        speedBuffText.text = "Speed Buff Active: " + value;
    }

    public void LowerHP()
    {
        health -= 10;
        health = Mathf.Clamp(health, 0, 100);
        healthText.text = "Health: " + health + "/" + 100;
    }

    public void LowerShield()
    {
        shield -= 10;
        shield = Mathf.Clamp(shield, 0, 100);
        shieldText.text = "Shield: " + shield + "/" + 100;
    }

    public void RemoveBuff()
    {
        speedBuffText.text = "Speed Buff Active: " + false;
    }
}
