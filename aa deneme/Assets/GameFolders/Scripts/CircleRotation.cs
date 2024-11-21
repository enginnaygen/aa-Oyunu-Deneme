using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CircleRotation : MonoBehaviour
{
    [SerializeField] Transform circleRotation;
    [SerializeField] float ýncreaseRotationSpeedAmount = 0.05f, rotationSpeed;
    [SerializeField] int counter = 15;
    [SerializeField] TextMeshProUGUI TextSayac;
    private float rotationDirection = 1;

    public static bool startGame = false;
 
    public int Counter { get { return counter; } set { counter = value; } }

    private void FixedUpdate()
    {

        Rotation();
        if(startGame)
        {
            TextSayac.text = counter.ToString();
        }

    }

    public void StartGame()
    {
        startGame = true;
        SceneManager.LoadScene(1);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            startGame = false;
        }
        if (counter == 0)
        {
            LevelCounter.Instance.LevelCount++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }   

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ýncreaseRotationSpeedAmount += 0.05f;
        rotationDirection *= -1;
    }
    public void Rotation()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 3)
        {
            circleRotation.Rotate(0, 0, rotationSpeed + ýncreaseRotationSpeedAmount);

        }
        if (SceneManager.GetActiveScene().buildIndex >= 4 && SceneManager.GetActiveScene().buildIndex < 7)
        {
            
            circleRotation.Rotate(0, 0, (rotationSpeed + ýncreaseRotationSpeedAmount) * rotationDirection);

        }
        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            RotationSpeedChange();
        }

    }

    void RotationSpeedChange()
    {

        circleRotation.Rotate(0, 0, rotationSpeed);
        rotationSpeed += Time.deltaTime;
        if(rotationSpeed>=3f)
        { rotationSpeed=0.7f; }   
    }

}





