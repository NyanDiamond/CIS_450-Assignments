using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Josh Bonovich
 * MovableBlock
 * Assignment 3
 * Code recieves input from its subject and then executes accordingly
 */
public class MovableBlock : MonoBehaviour, Observer

    
{
    [SerializeField] float speed = 10f;
    [SerializeField] Subject subject;
    // Start is called before the first frame update
    void Start()
    {
        subject = GameObject.FindObjectOfType<KeyboardControls>();
        subject.Register(this);
    }

    // Update is called once per frame
    void Observer.Update(List<int> lst)
    {
        StartCoroutine(Move(lst));
    }

    IEnumerator Move(List<int> lst)
    {
        List<int> store = lst;
        foreach (int temp in store.ToArray())
        {
            switch(temp)
            {
                //up
                case 1:
                    transform.Translate(Vector3.up * speed);
                    break;
                //down
                case 2:
                    transform.Translate(Vector3.down * speed);
                    break;
                //right
                case 3:
                    transform.Translate(Vector3.right * speed);
                    break;
                //up
                case 4:
                    transform.Translate(Vector3.left * speed);
                    break;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
