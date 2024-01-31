using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VelociytStick : MonoBehaviour
{
    [SerializeField] Rigidbody2D stickRb,circleRb;
    Transform stick, circle;
    CircleRotation circleRotation;

    private void Awake()
    {
        stick = GetComponent<Transform>();
        circle = FindObjectOfType<CircleRotation>().GetComponent<Transform>();
        circleRb = FindObjectOfType<CircleRotation>().GetComponent <Rigidbody2D>();
        circleRotation = FindObjectOfType<CircleRotation>().GetComponent<CircleRotation>();
    }

    private void Start()
    {
      
        stickRb.velocity = new Vector2(0, 6);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        stickRb.velocity = new Vector2(0, 0);

        if (collision.gameObject.tag=="Circle")
        {

            stick.transform.parent = circle.transform;
            circleRotation.Sayac--;
           
        }
        if (collision.gameObject.tag == "Stick")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }

    }

   /* private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            stickRb.velocity = new Vector2(0, 0);

        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            stickRb.velocity = new Vector2(0, 0);
        }

    }*/

}
