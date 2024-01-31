using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CircleRotation : MonoBehaviour
{
    [SerializeField] Transform circleRotation;
    [SerializeField] float donmeH�z�Artt�rma = 0.05f, donmeH�z�;
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


        donmeH�z�Artt�rma += 0.05f;
        donusYonu *= -1;

        /* if(donmeH�z� <= 0.3f)
         {
             donmeH�z� += 0.15f;
         }
         else if(donmeH�z� > 0.3f)
         {
             donmeH�z� -= 0.1f;
         }*/



    }
    public void Rotation()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 3)
        {
            circleRotation.Rotate(0, 0, donmeH�z� + donmeH�z�Artt�rma);
            //Debug.Log(0.3f + donmeH�z�Artt�rma);

        }
        if (SceneManager.GetActiveScene().buildIndex >= 4 && SceneManager.GetActiveScene().buildIndex < 7)
        {
            
            circleRotation.Rotate(0, 0, (donmeH�z� + donmeH�z�Artt�rma) * donusYonu);
            //Debug.Log((0.3f + donmeH�z�Artt�rma) * donusYonu);

            //StartCoroutine(RotationChange());
            Debug.Log((donmeH�z� + donmeH�z�Artt�rma) * donusYonu);

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
        circleRotation.Rotate(0, 0, donmeH�z�);

        yield return new WaitForSecondsRealtime(2);
        donmeH�z� += Time.deltaTime * 3;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� -= Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� += Time.deltaTime * 6;
        yield return new WaitForSecondsRealtime(4);
        donmeH�z� = 3;
    }*/

    /*IEnumerator RotationChange()
    {

       /* if (donmeH�z� == 0.3f)
        {
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeH�z�);
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeH�z�);
            yield return new WaitForSeconds(1);



        }
        if (donmeH�z� != 0.3f)
        {
            circleRotation.Rotate(0, 0, donmeH�z�);
            yield return new WaitForSeconds(1);
            circleRotation.Rotate(0, 0, donmeH�z�);
            yield return new WaitForSeconds(1);


        }
        Debug.Log(donmeH�z�);
    } */

    public void RotationSpeedChange()
    {

        circleRotation.Rotate(0, 0, donmeH�z�);
        donmeH�z� += Time.deltaTime;
        if(donmeH�z�>=3f)
        { donmeH�z�=0.7f; }
        
    }




    //donmeH�z� = Random.Range(0  , 5);






}





