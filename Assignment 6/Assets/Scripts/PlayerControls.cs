using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControls : MonoBehaviour
{
    float horizontalMovement = 10, jumpForce = 5;
    float movement=0;
    Rigidbody2D rb;
    Grounded gc;
    // Start is called before the first frame update
    void Start()
    {
        gc = GetComponentInChildren<Grounded>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) || !(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            movement = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement = 1;
        }
        Move();

        if(Input.GetKeyDown(KeyCode.Space) && gc.grounded)
        {
            Jump();
        }
    }

    private void Move()
    {
        rb.velocity = new Vector2(movement * horizontalMovement, rb.velocity.y);
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Consumable temp = collision.GetComponent<Consumable>();
        if(temp!=null)
        {
            float buff = 0;
            float val = temp.value;
            if (temp.isBuff)
            {
                buff = 1;
            }
            else
            {
                buff = -1;
            }

            switch (temp.type)
            {
                case "Speed":
                    horizontalMovement += val * buff;
                    if (horizontalMovement <= 1f) horizontalMovement = 1f;
                    break;
                case "Size":
                    transform.localScale += new Vector3(val * buff, val * buff, val * buff);
                    if (transform.localScale.x < .25f) transform.localScale = new Vector3(.25f, .25f, .25f);

                    break;
                case "Jump":
                    jumpForce += val * buff;
                    if (jumpForce <= .5f) jumpForce = .5f;
                    break;

            }
            Destroy(collision.gameObject);
        }
    }
}
