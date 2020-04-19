using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandClockShell : MonoBehaviour
{
    //This class controls triggers fromthe grand clock


    AudioSource heartbeat;
    public Material skirtPainting;

    //GameObject thermostat = GameObject.FindGameObjectWithTag("thermostat");
    //HVACBehavior hvacbehavior = thermostat.GetComponent<HVACBehavior>();
    //bool status = hvacbehavior.thermoStatus;


    private void Start()
    {
        heartbeat = GetComponent<AudioSource>();


    }


    // Update is called once per frame
    void Update()
    {

        //if (Vector3.Distance(collider.transform.position, gameObject.transform.position) > 2f)
        //{
        //if far enough, stop heartbeat
        //    heartbeat.Stop();
        //}
    }

    public void OnCollisionEnter(Collision collider)
    {
        if(GetComponent<ThermoStatInfo>().thermoTemp == 0)
        {
            //Debug.Log("collide");
            //if (Vector3.Distance(collider.transform.position, gameObject.transform.position) < 3f)
            //{
            if (collider.gameObject.tag == "Player")
            {
                //if close enough to clock, induce heartbeat
                heartbeat.Play();
                Debug.Log("heartbeat");
                GetComponent<Renderer>().material = skirtPainting;

                //if (status == true)
                // {
                //    Debug.Log("chnagetoskirt");
                //    GetComponent<Renderer>().material = skirtPainting;
                // }
            }

            //}
        }

    }


}
