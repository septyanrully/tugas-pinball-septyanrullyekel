using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
    {
        // Cek apakah objek yang menyentuh memiliki tag "Player"
        if (collision.gameObject.tag == "Player")
        {
            // Muat scene Game Over
            SceneManager.LoadScene(1);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
