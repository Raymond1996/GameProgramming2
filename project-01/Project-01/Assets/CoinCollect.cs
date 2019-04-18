using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public Text scoretext;
    //public Slider chidori;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
      scoretext.text = "score = " + score.ToString();
      //chidori.value = score;

    }

  private  void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.tag == "Coins")
       {
           score++;

           //chidori.value = score;

           if (score == 15) {
               scoretext.text = "WINNER";
           } else {
               scoretext.text = "score = " + score.ToString();
           }

           Destroy(other.gameObject);
           Debug.Log(score);
       }
    }
}
