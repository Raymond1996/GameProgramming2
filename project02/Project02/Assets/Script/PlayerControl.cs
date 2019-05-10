﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float speed;
    float jumpForce;
    float moveInput;
    Rigidbody2D rb;
    public float health;


    // Start is called before the first frame update
    void Start()
    {
      speed = 8;
      jumpForce=6;
      rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

      if(Input.GetKeyDown(KeyCode.UpArrow))
      {
         rb.velocity = Vector2.up * jumpForce;
      }
      if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
      {
           health -= Time.deltaTime;
           Debug.Log(health);
      }

    }

    void FixedUpdate()
    {
      moveInput = Input.GetAxis("Horizontal");
      rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }
}
