using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Runner : MonoBehaviour
{
    bool mousedOn = false;
    protected Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Template();
    }

    void Template()
    {
        RandomTurn();
        if(!mousedOn)
        {
            Move();
        }
    }

    void RandomTurn()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360f)));
    }

    protected abstract void Move();

    private void OnMouseEnter()
    {
        mousedOn = true;
        rb.velocity = Vector2.zero;
    }

    private void OnMouseExit()
    {
        mousedOn = false;
    }
}
