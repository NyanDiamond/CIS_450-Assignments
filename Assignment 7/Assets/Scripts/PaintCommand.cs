using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCommand : ICommand
{
    private Brush brush;
    private GameObject paint;

    public PaintCommand(Brush tempBrush)
    {
        brush = tempBrush;
    }

    public void Execute()
    {
        paint = (GameObject)Object.Instantiate(Resources.Load("Paint"), brush.transform.position, Quaternion.identity);
        paint.GetComponent<SpriteRenderer>().color = brush.colors[brush.colorIdx];
    }

    public void Undo()
    {
        Object.Destroy(paint);
    }
}
