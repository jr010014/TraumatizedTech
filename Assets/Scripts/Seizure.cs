using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seizure : MonoBehaviour
{
    public GameObject thermoStat;
    public Material seizurePainting;
    public GameObject seizureOnset;

    void OnCollisionEnter(Collision collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            if(seizureOnset.GetComponent<Respawn>().seizureOnset == true)
            {
                Debug.Log("seizurehit");
                Debug.Log(thermoStat.GetComponent<ThermoStatInfo>().thermoTemp);

                gameObject.GetComponent<Renderer>().material = seizurePainting;
            }
              
        }

    }
}
