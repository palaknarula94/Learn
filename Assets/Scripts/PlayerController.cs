using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    private float speed = 5.0f;
    private float turnSpeed = 25f;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //player movement
        transform.Translate(Vector3.forward *Time.deltaTime *speed * forwardInput);
        //player rotation
        transform.Rotate(Vector3.up, Time.deltaTime* horizontalInput * turnSpeed);
    }
}
