using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopWelcome
{
    private Text shopKeeperText;
    public ShopWelcome()
    {
        shopKeeperText = GameObject.FindGameObjectWithTag("ShopKeep").GetComponent<Text>();
        shopKeeperText.text = "Welcome to my shop. \nI hope you find what you are looking for.";
    }

    public void PurchaseComplete()
    {
        shopKeeperText.text = "Purchase complete, anything else?";
    }

    public void PurchaseIncomplete()
    {
        shopKeeperText.text = "Sorry, I can't sell you this.";
    }

    public void SellComplete()
    {
        shopKeeperText.text = "A fair sum wouldn't you say?";
    }

    public void SellIncomplete()
    {
        shopKeeperText.text = "You don't have any of that item to sell.";
    }
}
