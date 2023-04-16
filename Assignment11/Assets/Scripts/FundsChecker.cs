using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FundsChecker
{
    private float[] costs;
    private float currentMoney;
    private Text moneyText;

    public FundsChecker(float start)
    {
        costs = new float[] {5, 5, 1, 100};
        currentMoney = start;
        moneyText = GameObject.FindGameObjectWithTag("Cash").GetComponent<Text>();
        moneyText.text = "Cash: " + currentMoney;
    }

    public bool PurchaseItem(int item)
    {
        if (costs[item] > currentMoney) return false;
        else return true;
    }

    public void SellItem(int item)
    {
        currentMoney += costs[item];
        moneyText.text = "Cash: " + currentMoney;
    }

    public void PurchaseComplete(int item)
    {
        currentMoney -= costs[item];
        moneyText.text = "Cash: " + currentMoney;
    }

}
