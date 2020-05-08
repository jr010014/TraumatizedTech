﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public GameObject skyBoxShell;
    public GameObject thermoStat;
    public GameObject houseStruct;

    public bool materialsSet;

    void Start()
    {
        materialsSet = false;
        skyBoxShell.SetActive(false);
    }

    void Update()
    {
        if (materialsSet == false && thermoStat.GetComponent<ThermoStatInfo>().thermoTemp >= 0 && thermoStat.GetComponent<ThermoStatInfo>().thermoTemp < 5)
        {
            skyBoxShell.SetActive(true);

            foreach(Transform houseStructChild in houseStruct.transform)
            {
                houseStructChild.GetComponent<Renderer>().material = null;
            }

            materialsSet = true;

        }
        
    }
}
