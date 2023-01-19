using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich
 * Assignment 1
 * This abstract class if for every creature in the game
 */
public abstract class Creature 
{
    public int cr;
    protected int health;
    public void ChangeHP(int hp)
    {
        int temp = health + hp;
        Debug.Log("Health of creature changed from " + health + " to " + temp);
        health += hp;
        if (health <= 0) Die();
    }

    protected abstract void Die();


}
