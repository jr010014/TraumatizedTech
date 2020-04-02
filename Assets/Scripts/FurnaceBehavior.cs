using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceBehavior : MonoBehaviour {

    AudioSource metalBang;

	void Start () {
        metalBang = GetComponent<AudioSource>();
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        metalBang.Play();
    }
}
