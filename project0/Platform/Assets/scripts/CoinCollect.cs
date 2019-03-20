using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public Text scoreText;
    public Slider spidey;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
      scoreText.text = "score = " + score.ToString();
      spidey.value = score;

    }

    void OnCollisionEnter2D(Collision2D otherObject)
    {
       if (otherObject.gameObject.tag == "Pick Up")
       {
          score++;

          spidey.value=score;

          if(score == 100)
          {
            scoreText.text = "Winner";

          }
          else
          {
            scoreText.text = "score = " + score.ToString();
          }

          Destroy(otherObject.gameObject);
          Debug.Log(score);
       }
    }


}
