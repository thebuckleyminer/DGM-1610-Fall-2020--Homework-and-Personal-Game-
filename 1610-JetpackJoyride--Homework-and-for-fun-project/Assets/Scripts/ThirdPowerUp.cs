using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPowerUp : MonoBehaviour
{
    // The purpose of this power-up is to Double in size
    private void DoubleInSize()
    {
        transform.localScale = new Vector3(transform.localScale.x*2,transform.localScale.y*2,transform.localScale.z);
        print("Zoom");
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        DoubleInSize();
        
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