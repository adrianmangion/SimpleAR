using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitFox : MonoBehaviour
{

    public double speed;
    public float scalingSpeed = 0.5f;
	public float rotationSpeed = 70.0f;
	public float translationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
    }

}
