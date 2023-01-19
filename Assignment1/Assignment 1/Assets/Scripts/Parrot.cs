using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich
 * Assignment 1
 * This class implements the creature abstract class and the CanFly interface for a parrot
 */
public class Parrot : Creature, CanFly
{
    int height = 0;
    int maxHeight = 0;

    // Start is called before the first frame update
    public Parrot()
    {
        health = 2;
        cr = 0;
        //default value
        maxHeight = 10;
    }

    protected override void Die()
    {
        Debug.Log("Parrot dies then respawns");
        health = 2;
        height = 0;
    }

    public void Fly()
    {
        if (height<maxHeight)
        {
            Debug.Log("Parrot flies higher");
            height++;
        }
        else if(height>maxHeight)
        {
            Debug.Log("Parrot flies lower");
            height--;
        }
        else
        {
            Debug.Log("Parrot flies straight");
        }
    }

    public void SetMaxHeight(int temp)
    {
        maxHeight = temp;
        Debug.Log("Parrot's max height changed to " + temp);
    }
}
