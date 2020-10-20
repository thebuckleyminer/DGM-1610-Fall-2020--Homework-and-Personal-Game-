using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class AmmoPowerUp : MonoBehaviour
{
    public int ammoValue = 10;
    public int[] ammoBoostRandomChoice = {5, 10, 15, 20, 25};
    private void AmmoValueIncrease()
    {
        var ammoIndex = Random.Range(0, 5);
        ammoValue += ammoBoostRandomChoice[ammoIndex];
    }

    private void OnTriggerEnter(Collider other)
    {
        AmmoValueIncrease();
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