using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCommand : ICommand
{
    Brush brush;
    int change;

    public ColorCommand(Brush tempBrush, int temp)
    {
        brush = tempBrush;
        change = temp;
    }

    public void Execute()
    {
        if(change == -1)
        {
            brush.ColorDown();
        }
        else
        {
            brush.ColorUp();
        }
    }

    public void Undo()
    {
        if (change == -1)
        {
            brush.ColorUp();
        }
        else
        {
            brush.ColorDown();
        }
    }
}
