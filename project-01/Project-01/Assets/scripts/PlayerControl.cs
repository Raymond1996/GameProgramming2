﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float speed;
    float jumpForce;
    float moveInput;
    Rigidbody2D rb;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        jumpForce=4;
        rb=GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.UpArrow))
       {
          rb.velocity = Vector2.up * jumpForce;
       }

    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
