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
        if ( Vector3.Distance(collider.transform.position, gameObject.transform.position) < 2f)
        {
            //if close enough, induce heartbeat
            
            heartbeat.Play();
        }
        
    }
}
