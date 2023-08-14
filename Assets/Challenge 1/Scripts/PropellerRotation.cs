using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotation : MonoBehaviour
{
    //z axis
    private Vector3 rotAxis = new Vector3(0, 0, 1);
    private float rotSpeed=500f;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotAxis, rotSpeed * Time.deltaTime);
    }
}
