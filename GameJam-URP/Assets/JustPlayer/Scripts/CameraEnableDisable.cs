﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEnableDisable : MonoBehaviour
{

    public JPPlayerCam cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            cam.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            cam.enabled = true;
        }
    }
}
