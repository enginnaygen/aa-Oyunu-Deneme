using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene(1);
        SeviyeYazimi.Instance.Seviye = 1;
        //CircleRotation._seviye = 1;  
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Çýkýþ Yapýldý");
    }
}
