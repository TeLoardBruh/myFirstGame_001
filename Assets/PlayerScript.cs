﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // var 
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        // rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sideWayForce * Time.deltaTime,0,0);

        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideWayForce * Time.deltaTime,0,0);

        }
    }
}
