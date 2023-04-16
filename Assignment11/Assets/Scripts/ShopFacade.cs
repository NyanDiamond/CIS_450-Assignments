using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopFacade
{ 
    StockChecker sc;
    FundsChecker fc;
    ShopWelcome sw;

    public ShopFacade(float start)
    {
        sc = new StockChecker();
        fc = new FundsChecker(start);
        sw = new ShopWelcome();
    }

    public bool PurchaseItem(int item)
    {
        if(sc.CheckStock(item) && fc.PurchaseItem(item))
        {
            fc.PurchaseComplete(item);
            sc.PurchaseComplete(item);
            sw.PurchaseComplete();
            return true;
        }
        else
        {
            sw.PurchaseIncomplete();
            return false;
        }
    }

    public void Restock()
    {
        sc.RestockItem(0, 10);
        sc.RestockItem(1, 10);
        sc.RestockItem(2, 50);
    }

    public void SellItem(int item)
    {
        fc.SellItem(item);
        sc.RestockItem(item, 1);
        sw.SellComplete();
    }

    public void SellFail()
    {
        sw.SellIncomplete();
    }
}
