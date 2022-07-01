using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_switch : MonoBehaviour
{
    public GameObject CameraPast;
    public GameObject CameraNow;
    public GameObject CameraFuture;

    void Start()
    {
        CameraPast.SetActive(true);
        CameraNow.SetActive(false);
        CameraFuture.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            CameraPast.SetActive(true);
            CameraNow.SetActive(false);
            CameraFuture.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            CameraPast.SetActive(false);
            CameraNow.SetActive(true);
            CameraFuture.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            CameraPast.SetActive(false);
            CameraNow.SetActive(false);
            CameraFuture.SetActive(true);
        }
    }
}
