using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSRotation : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        

    }

    float mouseX;
    float mouseY;
    public bool invertedMouse;
    public GameObject body;

    // Update is called once per frame
    void Update()
    {
        
        mouseX += Input.GetAxis("Mouse X");
        if (invertedMouse)

        {

            mouseY += Input.GetAxis("Mouse Y");
        }

        else

        {

            mouseY -= Input.GetAxis("Mouse Y");

        }

        Debug.Log("X" + mouseX + " y Y "+ mouseY);
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
        body.transform.eulerAngles = new Vector3(0,mouseX,0);

    }
}
