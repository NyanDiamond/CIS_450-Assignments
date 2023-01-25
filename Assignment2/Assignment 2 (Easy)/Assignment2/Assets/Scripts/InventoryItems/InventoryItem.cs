using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class InventoryItem : MonoBehaviour
{
    protected Usable useType;
    public int stack;
    protected int value;
    public Text stackText;

    private void OnMouseDown()
    {
        if(stack>0)
        {
            useType.Use(value);
            stack--;
            stackText.text = stack.ToString();
        }
    }

    public void IncreaseStack()
    {
        stack++;
        stackText.text = stack.ToString();
    }

    protected abstract void Display();

}
