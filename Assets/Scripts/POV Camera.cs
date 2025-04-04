using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POVCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity=2f;
    float cameraVerticalRotation=0.25f;
    bool lockedCursor=true;

    // hide cursor
    void Start()
    {
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;

    }

    // Mouse Input
    void Update()
    {
        float inputX= Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY= Input.GetAxis("Mouse Y")*mouseSensitivity;

        cameraVerticalRotation-=inputY;
        cameraVerticalRotation=Mathf.Clamp(cameraVerticalRotation,-90f,90f);

        transform.localEulerAngles=Vector3.right * cameraVerticalRotation;
        player.Rotate(Vector3.up * inputX);
    }
}
/*public class SetClipping Planes: MonoBehaviour
{ 
    public Camera mainCamera;
    public float nearClipPlane = 0.1f;
    public float farClipPlane = 100f;
   
    void Start()
    {
        mainCamera.nearClipPlane = nearClipPlane;
        mainCamera.farClipPlane = farClipPlane;
    }

}*/