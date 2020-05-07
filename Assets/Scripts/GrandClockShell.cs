using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandClockShell : MonoBehaviour
{
    //This class controls triggers fromthe grand clock

    AudioSource heartbeat;
    public GameObject thermoStat;
    public Light clockLight;


    private void Start()
    {
        heartbeat = GetComponent<AudioSource>();

    }


    // Update is called once per frame
    void Update()
    {
        if (thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            //if touched tiggerering fireplace/traujma/seizing, then spiritual clock guide calls for you
            heartbeat.Play();
            Debug.Log("heartbeat");
            clockLight.enabled = true;
        }
    }

    public void OnCollisionEnter(Collision collider)
    {
        if (thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            if (collider.gameObject.tag == "Player")
            {
                
                thermoStat.GetComponent<ThermoStatInfo>().thermoTemp = 1;       //finding clock/skirt during seizure increases your temp, brings life back to you

            }
        }

    }


}
