using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thermoStatBehavior : MonoBehaviour
{

    void Start()
    {
        GetComponent<ThermoStatInfo>().thermoTemp = 5;

    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        GetComponent<ThermoStatInfo>().thermoTemp = 0;

    }

}
