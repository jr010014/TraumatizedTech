﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermoStatInfo : MonoBehaviour
{
    public int thermoTemp;    //0 to 5,0 being cold, 5 being hot

    public void Awake()
    {
        thermoTemp = 5;

    }
    

    public void Update()
    {
        switch (thermoTemp)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material.color = new Color32(95,3,255,0);
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material.color = new Color32(120,3,255,0);
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material.color = new Color32(255,0,150,0); 
                break;
            case 4:
                gameObject.GetComponent<Renderer>().material.color = new Color32(255,0,68,0);
                break;
            case 5:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;
        }
  
    }

}
