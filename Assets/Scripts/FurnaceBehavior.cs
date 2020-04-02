using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceBehavior : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
    }
}
