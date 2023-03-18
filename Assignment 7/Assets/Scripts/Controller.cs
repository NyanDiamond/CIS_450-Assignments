using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller: MonoBehaviour
{
    Stack<ICommand> comStack;
    bool replaying = false;

    void Start()
    {
        comStack = new Stack<ICommand>();
    }
    public void ExecuteCom(ICommand com)
    {
        if (!replaying)
        {
            com.Execute();
            comStack.Push(com);
        }
    }

    public void UndoCom()
    {
        if(!replaying && comStack.Count>0)  
            comStack.Pop().Undo();
    }

    public void ResetAll()
    {
        if(!replaying)
            while(comStack.Count>0)
            {
                comStack.Pop().Undo();
            }
    }

    public void Replay()
    {
        if (!replaying && comStack.Count>0)
        {
            ICommand[] temp = comStack.ToArray();
            ResetAll();
            replaying = true;
            StartCoroutine(Replaying(temp));
        }
    }

    private IEnumerator Replaying(ICommand[] coms)
    {
        for (int i = coms.Length - 1; i >= 0; i--)
        {
            yield return new WaitForSeconds(0.025f);
            coms[i].Execute();
            comStack.Push(coms[i]);
        }
        replaying = false;
    }
}
