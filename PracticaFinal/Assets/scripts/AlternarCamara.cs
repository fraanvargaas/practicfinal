using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternarCamara : MonoBehaviour
{
    public GameObject first;
    public GameObject third;
    public bool activa = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
           
            if (activa == true )
            {
                first.SetActive (false);
                third.SetActive(true);
                activa = false;
            }
            else
            {
                first.SetActive(true);
                third.SetActive(false);
                activa = true;
            }
        }
    }
   
}
