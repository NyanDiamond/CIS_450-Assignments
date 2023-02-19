using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    protected int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnBecameInvisible()
    {
        Collected();
    }

    protected void Collected()
    {
        FindObjectOfType<GameManager>().Add(value);
        Destroy(gameObject);
    }
}
