using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectItem : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag  == "food")
      {
          Destroy(collision.gameObject);
          PlayerControl.player.health+=10;
      }

      if(collision.gameObject.tag == "exit")
      {
         SceneManager.LoadScene("Level02");
      }
      if(collision.gameObject.tag == "end")
      {
        SceneManager.LoadScene("EndScene");
      }
    }
}
