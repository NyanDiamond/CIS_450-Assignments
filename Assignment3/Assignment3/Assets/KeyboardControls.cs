using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich
 * KeyboardControls
 * Assignment 3
 * Code controls the inputs and then sends them to the observers
 */
public class KeyboardControls : MonoBehaviour, Subject
{
    List<Observer> observers;
    List<int> lastDirections;
    List<int> currentDirections;

    // Start is called before the first frame update
    void Awake()
    {
        lastDirections = new List<int>();
        currentDirections = new List<int>();
        observers = new List<Observer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            currentDirections.Add(1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentDirections.Add(2);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentDirections.Add(3);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentDirections.Add(4);
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(observers.Count);
            Notify();
        }
    }    
    public void Notify()
    {
        foreach(Observer ob in observers)
        {
            if (currentDirections.Count != 0)
            {
                ob.Update(currentDirections);
                lastDirections = new List<int>(currentDirections);
                currentDirections.Clear();
            }
            else
            {
                ob.Update(lastDirections);
            }
        }
    }

    public void Register(Observer ob)
    {
        observers.Add(ob);
    }

    public void Unregister(Observer ob)
    {
        observers.Remove(ob);
    }

}
