using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thermoStatBehavior : MonoBehaviour
{
    public GameObject avatarHasFire;

    void Start()
    {
        GetComponent<ThermoStatInfo>().thermoTemp = 5;

    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (GetComponent<ThermoStatInfo>().thermoTemp == 5 && avatarHasFire.GetComponent<FireBehavior>().iAmTheFire == true)
        {
            GetComponent<ThermoStatInfo>().thermoTemp = 0;

        }

    }

}
