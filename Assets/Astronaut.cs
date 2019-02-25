﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
    Rigidbody rigidbody;



   

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); //Only act on components of type "Rigidbody"
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput() // Allows player to fly upwards and rotate.
    {
        if (Input.GetKey(KeyCode.W)) // Can Thrust While rotating
        {
            rigidbody.AddRelativeForce(Vector3.up); // Makes the player fly upwards
        }
        if (Input.GetKey(KeyCode.D))// Can't Rotate Left at same time.
        {
            transform.Rotate(Vector3.forward); // Makes the player rotate right
        }
        
        else if (Input.GetKey(KeyCode.A)) // Can't Rotate Right at same time
        {
            transform.Rotate(-Vector3.forward); //Makes the player rotate left
        }
    }
}   
