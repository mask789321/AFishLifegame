using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;
    float floatingInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;
        }
    }

    void Update()
    {
        MyInput();
        SpeedControl();
    }

    static public bool dialogue = false;

    private void FixedUpdate()
    {
        if (!dialogue)
        {
            MovePlayer();
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        floatingInput = Input.GetAxisRaw("Float");
    }

    private void MovePlayer()
    {
        moveDirection = (orientation.forward * verticalInput * Time.deltaTime) + (orientation.right * horizontalInput * Time.deltaTime) + (orientation.up * floatingInput * Time.deltaTime);

        rb.AddForce(moveDirection.normalized * moveSpeed * 5f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }
}
