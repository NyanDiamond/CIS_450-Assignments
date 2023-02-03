using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Josh Bonovich
 * Subject
 * Assignment 3
 * Interface for subjects
 */
public interface Subject
{
  
    public void Register(Observer ob);
    public void Unregister(Observer ob);

    public void Notify();
}
