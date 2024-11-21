using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelCounter : MonoBehaviour
{
    public static LevelCounter Instance;
    public int LevelCount { get; set; }
    CircleRotation _rotation;
    TextMeshProUGUI _textLevel;
    


    private void Start()
    {
        LevelSingleton();
        LevelCount = 1;
        _textLevel = FindObjectOfType<Canvas>().GetComponentInChildren<TextMeshProUGUI>();
        _rotation = FindObjectOfType<CircleRotation>().GetComponent<CircleRotation>();
    }
    void LevelSingleton()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    private void Update()
    {
       
        if (_rotation.Counter == 0 )
        { 
            LevelCount = SceneManager.GetActiveScene().buildIndex;
        }
        
        _textLevel = FindObjectOfType<TextMeshProUGUI>().GetComponent<TextMeshProUGUI>();
         _textLevel = FindObjectOfType<Canvas>().GetComponentInChildren<TextMeshProUGUI>();
        _rotation = FindObjectOfType<CircleRotation>().GetComponent<CircleRotation>();
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            Destroy(this.gameObject);
            return;
        }
        _textLevel.text = "Seviye " + LevelCount;

    }

}
