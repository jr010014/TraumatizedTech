using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermostatBehavior : MonoBehaviour
{
    public Light furnaceRoomLight;
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
        furnaceRoomLight.color = Color.red;
    }

}
