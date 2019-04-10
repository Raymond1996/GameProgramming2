using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    bool hitButton;
    bool getKey;
    public GameObject key;

    void Start()
    {
      hitButton = false;
      getKey = false;
      key.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(!hitButton)
       {
          // wait until button is hit
          if(collision.gameObject.tag == "button")
          {
             hitButton=true;
             key.SetActive(true);
             collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
          }

       }

       if(!getKey)
       {
          //wait until key is touch
          if(collision.gameObject.tag == "key")
          {
             getKey=true;
             key.SetActive(false);
          }
       }

       else
       {
          if(collision.gameObject.tag == "door")
          {
             collision.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
             collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
          }
       }
    }
}
