using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich
 * Assignment 1
 * This class implements the creature abstract class and the enemy interface for the goblin
 */
public class Goblin : Creature, Enemy
{
    // Start is called before the first frame update
    public Goblin()
    {
        health = 15;
        cr = 2;
    }

    protected override void Die()
    {
        Debug.Log("Goblin dies then respawns");
        health = 15;
        
    }

    public void Attack()
    {
        Debug.Log("Goblin attacks");
    }
}
