using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
   public GameObject GameOVER;

   private void OnEnable()
   {
     PlayerHealth.OnPlayerDeath += EnableGameOVER;

   }

   private void OnDisable()
   {
     PlayerHealth.OnPlayerDeath -= EnableGameOVER;
   }

   public void EnableGameOVER()
   {
    GameOVER.SetActive(true);
   }

   public void Restart()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
