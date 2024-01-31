using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Instantiate : MonoBehaviour
{
    [SerializeField] Transform stick, StartingPosition;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(stick, StartingPosition);
        }
    }
    
}
