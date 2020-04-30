using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandClockShell : MonoBehaviour
{
    //This class controls triggers fromthe grand clock

    AudioSource heartbeat;
    public GameObject thermoStat;



    private void Start()
    {
        heartbeat = GetComponent<AudioSource>();


    }


    // Update is called once per frame
    void Update()
    {


    }

    public void OnCollisionEnter(Collision collider)
    {
        if (thermoStat.GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            if (collider.gameObject.tag == "Player")
            {
                //if close enough to clock, induce heartbeat
                heartbeat.Play();
                Debug.Log("heartbeat");

                thermoStat.GetComponent<ThermoStatInfo>().thermoTemp = 1;       //finding clock/skirt during seizure increases your temp, brings life back to you

            }
        }
    



    }


}
