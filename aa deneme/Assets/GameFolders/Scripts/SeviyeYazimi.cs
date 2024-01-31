using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SeviyeYazimi : MonoBehaviour
{
    public static SeviyeYazimi Instance;
    public int Seviye { get; set; }
    CircleRotation _rotation;
    TextMeshProUGUI _textSeviye;
    


    private void Start()
    {
        SeviyeSingleton();
        Seviye = 1;
        _textSeviye = FindObjectOfType<Canvas>().GetComponentInChildren<TextMeshProUGUI>();
        _rotation = FindObjectOfType<CircleRotation>().GetComponent<CircleRotation>();



    }

    private void Update()
    {
       
        if (_rotation.Sayac == 0 )
        { 
            Seviye = SceneManager.GetActiveScene().buildIndex;
        }
        
        _textSeviye = FindObjectOfType<TextMeshProUGUI>().GetComponent<TextMeshProUGUI>();
         _textSeviye = FindObjectOfType<Canvas>().GetComponentInChildren<TextMeshProUGUI>();
        _rotation = FindObjectOfType<CircleRotation>().GetComponent<CircleRotation>();
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            Destroy(this.gameObject);
            return;
        }
        _textSeviye.text = "Seviye " + Seviye;


    }

    void SeviyeSingleton()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }


}
