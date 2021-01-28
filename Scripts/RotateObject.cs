using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject objectRotate;
    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    // Rotates object
    public void Rotate()
    {
        if(!rotateStatus)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(rotateStatus)
        {
            // Rotate object with speed property.
            objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
