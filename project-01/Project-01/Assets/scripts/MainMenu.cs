using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
      Application.LoadLevel(1);
   }
   public void OnStartGame()
    {
      //SceneManager.LoadScene("Level02");
    }

    public void QuitGame()
    {
      Debug.Log("QUIT!");
      Application.Quit();
    }
}
