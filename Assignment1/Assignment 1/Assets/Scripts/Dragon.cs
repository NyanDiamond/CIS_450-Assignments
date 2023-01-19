using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Josh Bonovich
 * Dragon
 * Assignment 1
 * This class implements the Creature abstract class as well as both the enemy and canfly interfaces for a dragon
 */
public class Dragon : Creature, CanFly, Enemy
{
    int height = 0;
    int maxHeight;

    // Start is called before the first frame update
    public Dragon()
    {
        health = 90;
        cr = 6;
        //default value
        maxHeight = 20;
    }

    protected override void Die()
    {
        Debug.Log("Dragon dies then respawns");
        health = 90;
        height = 0;
    }

    public void Fly()
    {
        if (height < maxHeight)
        {
            Debug.Log("Dragon flies higher");
            height++;
        }
        else if (height > maxHeight)
        {
            Debug.Log("Dragon flies lower");
            height--;
        }
        else
        {
            Debug.Log("Dragon flies straight");
        }
    }

    public void SetMaxHeight(int temp)
    {
        maxHeight = temp;
        Debug.Log("Dragon's max height changed to " + temp);
    }

    public void Attack()
    {
        Debug.Log("Dragon attacks");
    }
}
