using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Brush brush;
    private Vector2 dir;
    
    public MoveCommand(Brush tempBrush, Vector2 tempDir)
    {
        brush = tempBrush;
        dir = tempDir;
    }
    public void Execute()
    {
        brush.Move(dir);
    }

    public void Undo()
    {
        brush.Move(-dir);
    }
}
