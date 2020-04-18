using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HVACBehavior : MonoBehaviour
{
    public Light environmentLight;

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.blue;
        environmentLight.color = Color.blue;
    }

}
