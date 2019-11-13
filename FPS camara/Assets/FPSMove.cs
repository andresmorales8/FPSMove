using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    private Transform myTransform;
    public float speed = 1f;
    
    // Use this for initialization
    void Start()
    {

        myTransform = GetComponent<Transform>();

    }
    
    
   
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            myTransform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myTransform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myTransform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myTransform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }

    }
}