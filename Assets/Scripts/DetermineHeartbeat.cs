using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineHeartbeat : MonoBehaviour
{
    AudioSource heartbeat;

    private void Start()
    {
        heartbeat = GetComponent<AudioSource>();

    }
    private void Update()
    {
        //if (Vector3.Distance(collider.transform.position, gameObject.transform.position) > 2f)
        //{
            //if far enough, stop heartbeat
        //    heartbeat.Stop();
        //}
    }

    public void OnCollisionEnter(Collision collider)
    {
        //evaluate distance between player and objects that induce heartbeat
        if ( Vector3.Distance(collider.transform.position, gameObject.transform.position) < 3f)
        {
            if(collider.gameObject.tag == "grandClock")
            {
                //if close enough to clock, induce heartbeat
                heartbeat.Play();
                Debug.Log("heartbeat");
            }
            if (collider.gameObject.tag == "furnace")
            {
                //if close enough to furnace, induce breathing
                //heartbeat.Play();
                Debug.Log("breathing");
            }

        }
        
    }
}
