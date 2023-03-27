using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dasher : Runner
{
    [SerializeField] float speed = 5f;

    protected override void Move()
    {
        if(rb.velocity.magnitude < 1f)
        {
            rb.AddForce(speed * transform.right, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(-speed / 10 * rb.velocity.normalized, ForceMode2D.Force);
        }
    }
}
