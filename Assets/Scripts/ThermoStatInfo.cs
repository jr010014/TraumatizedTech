using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermoStatInfo : MonoBehaviour
{
    public int thermoTemp;    //0 to 5,0 being cold, 5 being hot

    public Material heart0;
    public Material heart1;
   // public Material heart2;
    //public Material heart3;
    //public Material heart4;
    public Material heart5;

    public void Awake()
    {
        thermoTemp = 5;

    }
    

    public void Update()
    {
        switch (thermoTemp)
        {
            case 0:
                gameObject.GetComponent<Renderer>().material = heart0; ;
                break;
            case 1:
                gameObject.GetComponent<Renderer>().material = heart1;
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
                gameObject.GetComponent<Renderer>().material = heart5;
                break;
        }
  
    }

}
