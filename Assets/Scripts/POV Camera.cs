using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POVCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity=2f;
    float cameraVerticalRotation=0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX= Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY= Input.GetAxis("Mouse Y")*mouseSensitivity;
        cameraVerticalRotation-=inputY;
        cameraVerticalRotation=Mathf.Clamp(cameraVerticalRotation,-90f,90f);
        
        transform.localEulerAngles=Vector3.right * cameraVerticalRotation;
        player.Rotate(Vector3.up*inputX);

    }
}
