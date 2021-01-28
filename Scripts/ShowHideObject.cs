using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHideObject : MonoBehaviour
{

public GameObject Object;
bool isShowing = false;

    // Start is called before the first frame update
    public void ToggleShow()
    {
        Text txtInfo;
        string description = "";
        GameObject plane;

        if(!isShowing)
        {
            Object.SetActive(true);
            isShowing = true;
        }
        else
        {
            Object.SetActive(false);
            isShowing = false;
        }

        switch(Object.tag)
        {
            case "Kitfox3":

            plane = GameObject.FindGameObjectWithTag("Kitfox3");
            gameObject.GetComponent<Text>().text = description;
            

            break;

            case "Spitfire":

            break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
