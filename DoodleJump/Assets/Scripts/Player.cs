using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))] 

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private SpriteRenderer sp;
    float movemnt = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        movemnt = Input.GetAxis("Horizontal") * speed;
        if (Input.GetAxis("Horizontal") < 0)
        {
            sp.flipX = true;
        }
        else if (Input.GetAxis("Horizontal") >0)
        {
            sp.flipX = false;
        }

    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movemnt;
        rb.velocity = velocity;
    }
}
