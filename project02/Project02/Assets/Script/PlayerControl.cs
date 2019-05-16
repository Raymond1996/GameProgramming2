using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerControl : MonoBehaviour
{
    float speed;
    float jumpForce;
    float moveInput;
    Rigidbody2D rb;
    public float health;
    public static PlayerControl player;
    public Text scoretext;


    // Start is called before the first frame update
    void Start()
    {
      speed = 8;
      jumpForce=6;
      rb=GetComponent<Rigidbody2D>();
      health=175;
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
      scoretext.text = "Health = " + health.ToString();

    }

    void FixedUpdate()
    {
      moveInput = Input.GetAxis("Horizontal");
      rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }
}
