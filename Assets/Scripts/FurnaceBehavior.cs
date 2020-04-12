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

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            metalBang.Play();
        }
    }
}
