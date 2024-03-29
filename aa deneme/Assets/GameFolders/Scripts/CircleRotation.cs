using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CircleRotation : MonoBehaviour
{
    [SerializeField] Transform circleRotation;
    [SerializeField] float donmeHızıArttırma = 0.05f, donmeHızı;
    [SerializeField] int sayac = 15;
    [SerializeField] TextMeshProUGUI TextSayac;// SeviyeText;
    private float donusYonu = 1;
    //public static int _seviye=0;

    //private int seconds=3;

    
    public int Sayac { get { return sayac; } set { sayac = value; } }




    private void FixedUpdate()
    {

        Rotation();
        TextSayac.text = sayac.ToString();
        //SeviyeText.text = "Seviye "+_seviye.ToString();

    }
    private void Update()
    {
        if (sayac == 0)
        {
            //_seviye++;
            SeviyeYazimi.Instance.Seviye++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        donmeHızıArttırma += 0.05f;
        donusYonu *= -1;

        /* if(donmeHızı <= 0.3f)
         {
             donmeHızı += 0.15f;
         }
         else if(donmeHızı > 0.3f)
         {
             donmeHızı -= 0.1f;
         }*/



    }
    public void Rotation()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 3)
        {
            circleRotation.Rotate(0, 0, donmeHızı + donmeHızıArttırma);
            //Debug.Log(0.3f + donmeHızıArttırma);

        }
        if (SceneManager.GetActiveScene().buildIndex >= 4 && SceneManager.GetActiveScene().buildIndex < 7)
        {
            
            circleRotation.Rotate(0, 0, (donmeHızı + donmeHızıArttırma) * donusYonu);
            //Debug.Log((0.3f + donmeHızıArttırma) * donusYonu);

            //StartCoroutine(RotationChange());
            Debug.Log((donmeHızı + donmeHızıArttırma) * donusYonu);

        }
        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            RotationSpeedChange();

            //StartCoroutine(RotationChangeSpeed());

            /*while (SceneManager.GetActiveScene().buildIndex >= 5)
            {
                StartCoroutine(RotationChange());

            }*/

        }

    }

    /*IEnumerator RotationChangeSpeed()
    {
        circleRotation.Rotate(0, 0, donmeHızı);

        yield return new WaitForSecondsRealtime(2);
        donmeHızı += Time.deltaTime * 3;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHızı = 3;
    }*/

    /*IEnumerator RotationChange()
    {

       /* if (donmeHızı == 0.3f)
        {
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeHızı);
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeHızı);
            yield return new WaitForSeconds(1);



        }
        if (donmeHızı != 0.3f)
        {
            circleRotation.Rotate(0, 0, donmeHızı);
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeHızı);
            yield return new WaitForSeconds(1);


        }
        Debug.Log(donmeHızı);
    } */

    public void RotationSpeedChange()
    {

        circleRotation.Rotate(0, 0, donmeHızı);
        donmeHızı += Time.deltaTime;
        if(donmeHızı>=3f)
        { donmeHızı=0.7f; }
        
    }




    //donmeHızı = Random.Range(0  , 5);






}





