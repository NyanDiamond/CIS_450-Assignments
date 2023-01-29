using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Josh Bonovich
//Assignment 2
//This script is the abstract class all inventory items defer to
public abstract class InventoryItem : MonoBehaviour
{
    protected Usable useType;
    public int stack;
    protected int value;
    public Text stackText;

    private void OnMouseDown()
    {
        FindObjectOfType<InventorySimulator>().Selection(this.gameObject, value, useType);
    }

    public void IncreaseStack()
    {
        stack++;
        stackText.text = stack.ToString();
    }

    public void Used()
    {
            stack--;
            stackText.text = stack.ToString();
    }

    protected abstract void Display();

}
