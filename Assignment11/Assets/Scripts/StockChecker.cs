using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StockChecker 
{
    private int[] stock;
    private Text[] valueText;

    public StockChecker()
    {
        stock = new int[] { 20, 20, 100, 0 };
        valueText = new Text[] {
        GameObject.FindGameObjectWithTag("Item1").GetComponent<Text>(),
        GameObject.FindGameObjectWithTag("Item2").GetComponent<Text>(),
        GameObject.FindGameObjectWithTag("Item3").GetComponent<Text>(),
        GameObject.FindGameObjectWithTag("Item4").GetComponent<Text>()
        };
        for (int i = 0; i<4; i++)
        {
            valueText[i].text = stock[i].ToString();
        }
    }

    public void PurchaseComplete(int item)
    {
        stock[item]--;
        valueText[item].text = stock[item].ToString();
    }

    public void RestockItem(int item, int amount)
    {
        stock[item] += amount;
        valueText[item].text = stock[item].ToString();
    }

    public bool CheckStock(int item)
    {
        return (stock[item] > 0);
    }
}
