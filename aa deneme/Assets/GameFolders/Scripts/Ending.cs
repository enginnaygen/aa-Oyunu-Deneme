using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
   public void Restart()
    {
        FindObjectOfType<CircleRotation>().StartGame();
        SceneManager.LoadScene(1);
        LevelCounter.Instance.LevelCount = 1;
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Çýkýþ Yapýldý");
    }
}
