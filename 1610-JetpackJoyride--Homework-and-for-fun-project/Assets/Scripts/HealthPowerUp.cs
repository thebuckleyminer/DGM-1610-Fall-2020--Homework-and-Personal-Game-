using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public int healthValue = 50;

    private void OnTriggerEnter(Collider other)
    {
        healthValue += 20;
        Destroy(other.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//
//[Homework] Write a health power-up
//Write a script that uses the method OnTriggerEnter.
//Right lines of code that will increase the health variable.