using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    Brush myBrush;
    Controller myController;
    // Start is called before the first frame update
    void Start()
    {
        myBrush = GameObject.FindObjectOfType<Brush>();
        myController = GameObject.FindObjectOfType<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            MoveCommand temp = new MoveCommand(myBrush, Vector2.up);
            myController.ExecuteCom(temp);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MoveCommand temp = new MoveCommand(myBrush, -Vector2.up);
            myController.ExecuteCom(temp);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveCommand temp = new MoveCommand(myBrush, -Vector2.right);
            myController.ExecuteCom(temp);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveCommand temp = new MoveCommand(myBrush, Vector2.right);
            myController.ExecuteCom(temp);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PaintCommand temp = new PaintCommand(myBrush);
            myController.ExecuteCom(temp);
        }
    }

    public void Undo()
    {
        myController.UndoCom();
    }

    public void _Reset()
    {
        myController.ResetAll();
    }

    public void Replay()
    {
        myController.Replay();
    }

    public void ChangeColor(int temp1)
    {
        ColorCommand temp = new ColorCommand(myBrush, temp1);
        myController.ExecuteCom(temp);
    }
}
