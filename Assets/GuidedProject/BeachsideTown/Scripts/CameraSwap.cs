using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public Camera mainCamera;
    public Camera wideCamera;
    public Camera closeUpCamera;
    public Camera midRangeCamera;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            ActivateMainCamera();
        }
        else if(Input.GetKeyDown("2"))
        {
            ActivateWideCamera();
        }
        else if(Input.GetKeyDown("3"))
        {
            ActivateCloseUpCamera();
        }
        else if(Input.GetKeyDown("4"))
        {
            ActivateMidRangeCamera();
        }
    }

    private void ActivateMainCamera()
    {
        mainCamera.enabled = true;
        wideCamera.enabled = false;
        closeUpCamera.enabled = false;
        midRangeCamera.enabled = false;
    }

    public void GetActiveMainCamera()
    {
        ActivateMainCamera();
    }

    private void ActivateWideCamera()
    {
        mainCamera.enabled = false;
        wideCamera.enabled = true;
        closeUpCamera.enabled = false;
        midRangeCamera.enabled = false;
    }

    public void GetActiveWideCamera()
    {
        ActivateWideCamera();
    }

    private void ActivateCloseUpCamera()
    {
        mainCamera.enabled = false;
        wideCamera.enabled = false;
        closeUpCamera.enabled = true;
        midRangeCamera.enabled = false;
    }

    public void GetActiveCloseUpCamera()
    {
        ActivateCloseUpCamera();
    }

    private void ActivateMidRangeCamera()
    {
        mainCamera.enabled = false;
        wideCamera.enabled = false;
        closeUpCamera.enabled = false;
        midRangeCamera.enabled = true;
    }

    public void GetActiveMidRangeCamera()
    {
        ActivateMidRangeCamera();
    }
}
