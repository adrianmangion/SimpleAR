using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOut : MonoBehaviour
{
    public GameObject Object;
    
    private bool _ZoomIn;
    private bool _ZoomOut;
    public float Scale = 0.1f;

    // Update is called once per frame
    void Update()
    {
        if(_ZoomIn)
        {
            // Scale up object
            Object.transform.localScale += new Vector3(Scale, Scale, Scale);
        }

        if(_ZoomOut)
        {
            // Scale down object
            Object.transform.localScale -= new Vector3(Scale, Scale, Scale);
        }
    }

    public void OnPressZoomIn()
    {
        _ZoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        _ZoomIn = false;
    }

    public void OnPressZoomOut()
    {
        _ZoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        _ZoomOut = false;
    }
}
