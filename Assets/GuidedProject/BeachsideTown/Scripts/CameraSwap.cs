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
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivateMainCamera();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivateWideCamera();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivateCloseUpCamera();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActivateMidRangeCamera();
        }
    }

    // Activate camera that send into it
    private void ActivateCamera(Camera cam)
    {
        mainCamera.enabled = false;
        wideCamera.enabled = false;
        midRangeCamera.enabled = false;
        closeUpCamera.enabled = false;

        cam.enabled = true;
    }

    public void ActivateMainCamera()
    {
        ActivateCamera(mainCamera);
    }

    public void ActivateWideCamera()
    {
        ActivateCamera(wideCamera);
    }

    public void ActivateMidRangeCamera()
    {
        ActivateCamera(midRangeCamera);
    }

    public void ActivateCloseUpCamera()
    {
        ActivateCamera(closeUpCamera);
    }
    /*
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
    */
}
