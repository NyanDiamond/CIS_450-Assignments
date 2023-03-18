using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Consumable : MonoBehaviour
{
    public float value;
    public string type;
    public bool isBuff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowards();
    }

    void MoveTowards()
    {
        float temp = 0;
        if(isBuff)
        {
            temp = -1;
        }
        else
        {
            temp = 1;
        }
        transform.Translate(new Vector2((GameObject.Find("Player").transform.position.x - transform.position.x), 0).normalized * 4 * Time.deltaTime * temp);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
