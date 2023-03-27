using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : Runner
{
    [SerializeField] float speed;

    protected override void Move()
    {
        rb.AddForce(transform.right * speed, ForceMode2D.Force);
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, speed);
    }
}
