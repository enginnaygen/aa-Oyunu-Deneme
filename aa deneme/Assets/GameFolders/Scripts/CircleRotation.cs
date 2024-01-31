using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CircleRotation : MonoBehaviour
{
    [SerializeField] Transform circleRotation;
    [SerializeField] float donmeHýzýArttýrma = 0.05f, donmeHýzý;
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


        donmeHýzýArttýrma += 0.05f;
        donusYonu *= -1;

        /* if(donmeHýzý <= 0.3f)
         {
             donmeHýzý += 0.15f;
         }
         else if(donmeHýzý > 0.3f)
         {
             donmeHýzý -= 0.1f;
         }*/



    }
    public void Rotation()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 3)
        {
            circleRotation.Rotate(0, 0, donmeHýzý + donmeHýzýArttýrma);
            //Debug.Log(0.3f + donmeHýzýArttýrma);

        }
        if (SceneManager.GetActiveScene().buildIndex >= 4 && SceneManager.GetActiveScene().buildIndex < 7)
        {
            
            circleRotation.Rotate(0, 0, (donmeHýzý + donmeHýzýArttýrma) * donusYonu);
            //Debug.Log((0.3f + donmeHýzýArttýrma) * donusYonu);

            //StartCoroutine(RotationChange());
            Debug.Log((donmeHýzý + donmeHýzýArttýrma) * donusYonu);

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
        circleRotation.Rotate(0, 0, donmeHýzý);

        yield return new WaitForSecondsRealtime(2);
        donmeHýzý += Time.deltaTime * 3;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeHýzý = 3;
    }*/

    /*IEnumerator RotationChange()
    {

       /* if (donmeHýzý == 0.3f)
        {
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeHýzý);
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeHýzý);
            yield return new WaitForSeconds(1);



        }
        if (donmeHýzý != 0.3f)
        {
            circleRotation.Rotate(0, 0, donmeHýzý);
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeHýzý);
            yield return new WaitForSeconds(1);


        }
        Debug.Log(donmeHýzý);
    } */

    public void RotationSpeedChange()
    {

        circleRotation.Rotate(0, 0, donmeHýzý);
        donmeHýzý += Time.deltaTime;
        if(donmeHýzý>=3f)
        { donmeHýzý=0.7f; }
        
    }




    //donmeHýzý = Random.Range(0  , 5);






}





