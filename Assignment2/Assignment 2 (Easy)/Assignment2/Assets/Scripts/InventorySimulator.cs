using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Josh Bonovich
//Assignment 2
//The main controller of the inventory system
public class InventorySimulator : MonoBehaviour
{
    public Text healthText;
    public Text shieldText;
    public Text speedBuffText;
    public Button use;
    public GameObject border;
    private Usable strategy;
    private int currentValue;
    private InventoryItem currentItem;
    private int health = 100;
    private int shield = 100;
    // Start is called before the first frame update
    private void Start()
    {
        use.enabled = false;
        border.SetActive(false);
        
    }
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

    public void Selection(GameObject temp, int tempVal, Usable tempStrat)
    {
        currentItem = temp.GetComponent<InventoryItem>();
        if (!border.activeInHierarchy)
        {
            border.SetActive(true);
            use.enabled = true;
        }
        border.transform.position = temp.transform.position;
        strategy = tempStrat;
        currentValue = tempVal;
    }

    public void Use()
    {
        if (currentItem.stack > 0)
        {
            currentItem.Used();
            strategy.Use(currentValue);
        }
    }
}
