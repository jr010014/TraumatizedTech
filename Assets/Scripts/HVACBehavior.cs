using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HVACBehavior : MonoBehaviour
{
    public bool thermoStatus; //1 or true = blue, 0 or false = red

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        thermoStatus = false;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        thermoStatus = true;
        GetComponent<Renderer>().material.color = Color.blue;
    }

}
