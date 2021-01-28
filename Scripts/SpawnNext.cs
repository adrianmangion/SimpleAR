using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnNext : MonoBehaviour
{
    public GameObject objectToHide, objectToShow;
    public Text description;

    public void SpawnNextObject()
    {
        if(objectToHide.activeSelf)
        {
            // KitFox3
            objectToHide.SetActive(false);
            objectToShow.SetActive(true);
            description.text = @"Airplane: Denney Kitfox
                                 Model: 3
                                 Origin: USA 
                                 Built: 1984"; 
        }
        else
        {
            // Spitfire
            objectToShow.SetActive(false);
            objectToHide.SetActive(true);
            description.text = @"Airplane: Supermarine Spitfire
                                 Wingspan: 11m
                                 Origin: Great Britain 
                                 Built: 1936"; 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
