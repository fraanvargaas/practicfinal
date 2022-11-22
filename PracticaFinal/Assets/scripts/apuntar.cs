using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apuntar : MonoBehaviour
{
    public GameObject normal;
    public GameObject aimcam;
    public GameObject croshair;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            normal.SetActive(false);
            aimcam.SetActive(true);
            croshair.SetActive(false);
        }
        else
        {
            normal.SetActive(true);
            aimcam.SetActive(false);
            croshair.SetActive(true);
        }
    }
}
