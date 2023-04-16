using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] float startingMoney;
    int[] inventory;
    [SerializeField] Text[] valueText;
    ShopFacade sf;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new int[] { 0, 0, 0, 100 };
        sf = new ShopFacade(startingMoney);
    }

    public void BuyItem(int item)
    {
        if (sf.PurchaseItem(item))
        {
            inventory[item]++;
            valueText[item].text = inventory[item].ToString();
        }
    }

    public void SellItem(int item)
    {
        if(inventory[item]>0)
        {
            inventory[item]--;
            valueText[item].text = inventory[item].ToString();
            sf.SellItem(item);
        }
        else
        {
            sf.SellFail();
        }
    }

    public void Restock()
    {
        sf.Restock();
    }
}
